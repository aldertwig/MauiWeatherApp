using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class Sys
    {
        [JsonPropertyName("pod")]
        public string? Pod { get; set; }
    }
}
