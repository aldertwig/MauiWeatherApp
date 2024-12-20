﻿using System.Net.Http.Json;
using System.Text.Json;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    //api.openweathermap.org/data/2.5/forecast?lat={lat}&lon={lon}&appid={API key}
    //https://openweathermap.org/img/wn/10d@2x.png
    //http://api.openweathermap.org/geo/1.0/direct?q={city name},{state code},{country code}&limit={limit}&appid={API key}

    public class WeatherForecastService
    {
        HttpClient httpClient;
        WeatherForecastResponse forecasts = new();
        List<GeoLocation> geoLocation = new();
        private readonly string _key = "7aeffc61bcc33289abfb963dc9b1ee7c";
        private readonly string countryCode = "se";

        public WeatherForecastService()
        {
            httpClient = new HttpClient();
        }

        public async Task <WeatherForecastResponse> GetForecast(double? lat, double? lon) {
            var url = $"https://api.openweathermap.org/data/2.5/forecast?lat={lat}&lon={lon}&units=metric&appid={_key}";
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode) {
                var jsonString = await response.Content.ReadAsStringAsync();
                forecasts = JsonSerializer.Deserialize<WeatherForecastResponse>(jsonString);
            }
            return forecasts;
        }

        public async Task <List<GeoLocation>> GetGeoLocation(string? city)
        {
            if (city is not null)
            {
                var url = $"https://api.openweathermap.org/geo/1.0/direct?q={city},{countryCode}&appid={_key}";
                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    geoLocation = null;
                    geoLocation = await response.Content.ReadFromJsonAsync<List<GeoLocation>>();
                }
                return geoLocation;
            }
            return null;
        }
    }
}
