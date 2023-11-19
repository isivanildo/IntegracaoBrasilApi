using AutoMapper;
using Dtos;
using Interfaces;
using Models;

namespace Services
{
    public class BancoService : IBanco
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public BancoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<BancoResponse>> BuscarBanco(string codigoBanco)
        {
            var banco = await _brasilApi.BuscarBanco(codigoBanco);
            return _mapper.Map<ResponseGenerico<BancoResponse>>(banco);
        }

        public async Task<ResponseGenerico<List<BancoResponse>>> BuscaTodosBancos()
        {
            var bancos = await _brasilApi.BuscaTodosBancos();
            return _mapper.Map<ResponseGenerico<List<BancoResponse>>>(bancos);
        }

    }
}