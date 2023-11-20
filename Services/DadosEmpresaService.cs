using AutoMapper;
using Dtos;
using Interfaces;

namespace Services
{
    public class DadosEmpresaService : IDadosEmpresa
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public DadosEmpresaService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }


        public async Task<ResponseGenerico<DadosEmpresaResponse>> BuscaEmpresa(string cnpj)
        {
            var empresa = await _brasilApi.BuscaEmpresa(cnpj);

            return _mapper.Map<ResponseGenerico<DadosEmpresaResponse>>(empresa);
        }

    }
}