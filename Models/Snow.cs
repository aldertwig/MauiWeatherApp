using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class Snow
    {
        [JsonPropertyName("3h")]
        public double? _3h { get; set; }
    }
}
