using Dtos;

namespace Interfaces
{
    public interface IEnderecoMultiplo
    {
        Task<ResponseGenerico<EnderecoMultiploResponse>> BuscarEnderecoPorCepV2(string cep);
    }
}