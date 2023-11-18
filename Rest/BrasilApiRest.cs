using System.Dynamic;
using System.Text.Json;
using Dtos;
using Interfaces;
using Models;

namespace Rest
{
    public class BrasilApiRest : IBrasilApi
    {
        public Task<ResponseGenerico<Banco>> BuscarBanco(string codigoBanco)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseGenerico<Endereco>> BuscarEnderecoPorCep(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");
            var response = new ResponseGenerico<Endereco>();

            using (var client = new HttpClient()) 
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<Endereco>(contentResponse);

                if (responseBrasilApi.IsSuccessStatusCode) 
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetornados = objResponse;
                }
                else 
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErroRetornado = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }

            return response;
        }

        public Task<ResponseGenerico<List<Banco>>> BuscaTodosBancos()
        {
            throw new NotImplementedException();
        }

    }
}