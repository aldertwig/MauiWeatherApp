using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private readonly WeatherForecastService _weatherForecastService;
        [ObservableProperty]
        ObservableCollection<WeatherForecast> forecast = new ObservableCollection<WeatherForecast>();

        [ObservableProperty]
        string? location;

        public MainViewModel(WeatherForecastService forecastService)
        {
            _weatherForecastService = forecastService;
        }

        [RelayCommand]
        async void UseMyLocation()
        {
            forecast.Clear();
            var geoLocation = new GeoLocation() { Lat = 63.8256568, Lon = 20.2630745 };
            //var forecastResponse = _weatherForecastService.GetForecast();
            Title = "Umeå";
            GetForecast(geoLocation);
        }

        [RelayCommand]
        async void GetGeoLocation()
        {
            forecast.Clear();
            //var forecastResponse = _weatherForecastService.Get();
        }

        [RelayCommand]
        async void GetForecast(GeoLocation geoLocation)
        {
            forecast.Clear();
            var forecastResult = await _weatherForecastService.GetForecast(geoLocation.Lat, geoLocation.Lon);
            foreach (var forecastItem in forecastResult.List)
            {
                forecast.Add(new WeatherForecast() { Temp = forecastItem.Main.Temp, Date = forecastItem.DtTxt, IconURL = "https://openweathermap.org/img/wn/" + forecastItem.Weather.First().Icon + "@2x.png", WeatherMain = forecastItem.Weather.First().Main });
            }
        }
    }
}
