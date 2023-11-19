using Dtos;
using Models;

namespace Interfaces
{
    public interface IBanco
    {
        Task<ResponseGenerico<List<BancoResponse>>> BuscaTodosBancos();
        Task<ResponseGenerico<BancoResponse>> BuscarBanco(string codigoBanco);
    }
}