using System.Text.Json.Serialization;

namespace Models
{
    public class CnaesSecundario
    {
        [JsonPropertyName("codigo")]
        public int? Codigo { get; set; }

        [JsonPropertyName("descricao")]
        public string? Descricao { get; set; }

    }
}