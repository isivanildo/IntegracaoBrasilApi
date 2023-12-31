using Dtos;

namespace Interfaces
{
    public interface IEndereco
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
        Task<ResponseGenerico<EnderecoMultiploResponse>> BuscarEnderecoPorCepV2(string cep);

    }
}