using System.Text.Json.Serialization;
using Models;

namespace Dtos
{
    public class EnderecoMultiploResponse :  EnderecoResponse
    {
        [JsonPropertyOrder(1)]
        public Localizacao? Localizacao { get; set; }
    }
}