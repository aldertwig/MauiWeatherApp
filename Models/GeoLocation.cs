using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class GeoLocation
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("local_names")]
        public LocalNames LocalNames { get; set; }

        [JsonPropertyName("lat")]
        public double? Lat { get; set; }

        [JsonPropertyName("lon")]
        public double? Lon { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }
    }

    public class LocalNames
    {
        [JsonPropertyName("lt")]
        public string Lt { get; set; }

        [JsonPropertyName("he")]
        public string He { get; set; }

        [JsonPropertyName("eo")]
        public string Eo { get; set; }

        [JsonPropertyName("et")]
        public string Et { get; set; }

        [JsonPropertyName("sr")]
        public string Sr { get; set; }

        [JsonPropertyName("fi")]
        public string Fi { get; set; }

        [JsonPropertyName("pl")]
        public string Pl { get; set; }

        [JsonPropertyName("ru")]
        public string Ru { get; set; }

        [JsonPropertyName("se")]
        public string Se { get; set; }

        [JsonPropertyName("uk")]
        public string Uk { get; set; }

        [JsonPropertyName("hu")]
        public string Hu { get; set; }

        [JsonPropertyName("sv")]
        public string Sv { get; set; }
    }
}
