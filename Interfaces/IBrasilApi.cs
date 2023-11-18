using Dtos;
using Models;

namespace Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<Endereco>> BuscarEnderecoPorCep(string cep);
        Task<ResponseGenerico<List<Banco>>> BuscaTodosBancos();
        Task<ResponseGenerico<Banco>> BuscarBanco(string codigoBanco);
    }
}