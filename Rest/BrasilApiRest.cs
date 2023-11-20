using System.Dynamic;
using System.Text.Json;
using Dtos;
using Interfaces;
using Models;

namespace Rest
{
    public class BrasilApiRest : IBrasilApi
    {
        public async Task<ResponseGenerico<Banco>> BuscarBanco(string codigoBanco)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1/{codigoBanco}");
            var response = new ResponseGenerico<Banco>();

            using (var client = new HttpClient()) 
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<Banco>(contentResponse);

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

        public async Task<ResponseGenerico<EnderecoMultiplo>> BuscarEnderecoPorCepV2(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v2/{cep}");
            var response = new ResponseGenerico<EnderecoMultiplo>();

            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<EnderecoMultiplo>(contentResponse);

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

        public async Task<ResponseGenerico<List<Banco>>> BuscaTodosBancos()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1");
            var response = new ResponseGenerico<List<Banco>>();

            using (var client = new HttpClient()) 
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<List<Banco>>(contentResponse);

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

        public async Task<ResponseGenerico<DadosEmpresa>> BuscaEmpresa(string cnpj)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cnpj/v1/{cnpj}");
            var response = new ResponseGenerico<DadosEmpresa>();

            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<DadosEmpresa>(contentResponse);

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

    }
}