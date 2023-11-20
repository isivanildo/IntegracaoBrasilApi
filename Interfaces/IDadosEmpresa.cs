using Dtos;

namespace Interfaces
{
    public interface IDadosEmpresa
    {
        Task<ResponseGenerico<DadosEmpresaResponse>> BuscaEmpresa(string cnpj);
    }
}