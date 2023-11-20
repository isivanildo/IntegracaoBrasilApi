using System.Text.Json.Serialization;

namespace Models
{
    public class Coordenadas
    {
        [JsonPropertyName("longitude")]
        public string? Longitude { get; set; }

        [JsonPropertyName("latitude")]
        public string? Latitude { get; set; }
    }
}