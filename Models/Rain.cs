using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class Rain
    {
        [JsonPropertyName("3h")]
        public double? _3h { get; set; }
    }
}
