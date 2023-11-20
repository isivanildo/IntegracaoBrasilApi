using System.Text.Json.Serialization;

namespace Models
{
    public class Localizacao
    {
        [JsonPropertyName("type")]
        public string? Tipo { get; set; }

        [JsonPropertyName("coordinates")]
        public Coordenadas? Coordenadas { get; set; } 
    }
}