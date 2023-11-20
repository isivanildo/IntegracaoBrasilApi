using AutoMapper;
using Dtos;
using Interfaces;

namespace Services
{
    public class EnderecoService : IEndereco
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public EnderecoService(IMapper mapper, IBrasilApi brasilApi) 
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }
        
        public async Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep)
        {
            var endereco = await _brasilApi.BuscarEnderecoPorCep(cep);
            return _mapper.Map<ResponseGenerico<EnderecoResponse>>(endereco);
        }

        public async Task<ResponseGenerico<EnderecoMultiploResponse>> BuscarEnderecoPorCepV2(string cep)
        {
            var endereco = await _brasilApi.BuscarEnderecoPorCepV2(cep);

            return _mapper.Map<ResponseGenerico<EnderecoMultiploResponse>>(endereco);
        }

    }
}