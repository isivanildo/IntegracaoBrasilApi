using Dtos;

namespace Interfaces
{
    public interface IEndereco
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);

    }
}