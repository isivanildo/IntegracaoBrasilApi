using AutoMapper;
using Dtos;
using Models;

namespace Mappings
{
    public class DadosEmpresaMapping : Profile
    {
        public DadosEmpresaMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<DadosEmpresaResponse, DadosEmpresa>();
            CreateMap<DadosEmpresa, DadosEmpresaResponse>();
        }
    }
}