using System.Text.Json.Serialization;

namespace Models
{
    public class EnderecoMultiplo : Endereco
    {
        [JsonPropertyName("location")]
        public Localizacao? Localizacao { get; set; }
    }
}