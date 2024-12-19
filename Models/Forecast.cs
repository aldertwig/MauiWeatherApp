namespace WeatherApp.Models
{
    public class Forecast
    {
        public double? Temp { get; set; }
        public string? Date { get; set; }
        public string? Time { get; set; }
        public double? Wind { get; set; }
        public string? IconURL { get; set; }
        public string? WeatherMain { get; set; }
    }
}
