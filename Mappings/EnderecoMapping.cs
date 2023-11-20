using AutoMapper;
using Dtos;
using Models;

namespace Mappings
{
    public class EnderecoMapping : Profile
    {
        public EnderecoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EnderecoResponse, Endereco>();
            CreateMap<Endereco, EnderecoResponse>();
            CreateMap<EnderecoMultiploResponse, EnderecoMultiplo>();
            CreateMap<EnderecoMultiplo, EnderecoMultiploResponse>();
        }
    }
}