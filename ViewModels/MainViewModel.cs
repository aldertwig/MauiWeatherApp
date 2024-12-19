using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public partial class MainViewModel(WeatherForecastService forecastService) : BaseViewModel
    {
        private readonly WeatherForecastService _weatherForecastService = forecastService;
        [ObservableProperty]
        private ObservableCollection<Forecast> _forecasts = new();
        [ObservableProperty]
        bool isFetching;
        [ObservableProperty]
        string? location;
        [ObservableProperty]
        string? city;

        [RelayCommand]
        async void UseMyLocation()
        {
            try
            {
                Forecasts.Clear();
                IsFetching = true;
                var location = await GetCurrentLocation();
                GetForecast(new GeoLocation() { Lat = location.Latitude, Lon = location.Longitude });
            }
            catch (Exception ex)
            {
                CancelRequest();
                await Shell.Current.DisplayAlert("Alert", ex.Message, "Ok");
                IsFetching = false;
            }
        }

        [RelayCommand]
        async void GetGeoLocation()
        {
            if (Location is not null)
            {
                try
                {
                    Forecasts.Clear();
                    IsFetching = true;
                    var geoLocationResponse = await _weatherForecastService.GetGeoLocation(Location);
                    if (geoLocationResponse.FirstOrDefault() != null)
                    {
                        GetForecast(geoLocationResponse.FirstOrDefault());
                    }
                    else
                    {
                        IsFetching = false;
                        await Shell.Current.DisplayAlert("Info", $"Could not find location: {Location}", "Ok");
                    }
                }
                catch (Exception ex)
                {
                    await Shell.Current.DisplayAlert("Alert", ex.Message, "Ok");
                    IsFetching = false;
                }
            }
        }

        [RelayCommand]
        async void GetForecast(GeoLocation geoLocation)
        {
            Forecasts.Clear();
            var forecastResult = await _weatherForecastService.GetForecast(geoLocation.Lat, geoLocation.Lon);
            City = forecastResult.City.Name;

            foreach (var forecastItem in forecastResult.List)
            {
                var dateTime = forecastItem.DtTxt.Split(" ");
                Forecasts.Add(new Forecast() { Temp = forecastItem.Main.Temp, Wind = forecastItem.Wind.Speed, Date = dateTime[0], Time = dateTime[1], IconURL = "https://openweathermap.org/img/wn/" + forecastItem.Weather.First().Icon + "@2x.png", WeatherMain = forecastItem.Weather.First().Main });
            }
            IsFetching = false;
        }

        [ObservableProperty]
        private CancellationTokenSource _cancelTokenSource;
        [ObservableProperty]
        private bool _isCheckingLocation;

        [RelayCommand]
        public async Task<Location> GetCurrentLocation()
        {
            Location location = null;
            try
            {
                _isCheckingLocation = true;

                GeolocationRequest request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));

                _cancelTokenSource = new CancellationTokenSource();

                location = await Geolocation.Default.GetLocationAsync(request, _cancelTokenSource.Token);

                //if (location != null)
                //    await Shell.Current.DisplayAlert("Alert", $"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}", "Ok");
                return location;
            }
            // Catch one of the following exceptions:
            //   FeatureNotSupportedException
            //   FeatureNotEnabledException
            //   PermissionException
            catch (Exception ex)
            {
                // Unable to get location
                await Shell.Current.DisplayAlert("Alert", ex.Message, "Ok");
            }
            finally
            {
                _isCheckingLocation = false;
            }
            return location;
        }

        public void CancelRequest()
        {
            if (_isCheckingLocation && _cancelTokenSource != null && _cancelTokenSource.IsCancellationRequested == false)
                _cancelTokenSource.Cancel();
        }
    }
}
