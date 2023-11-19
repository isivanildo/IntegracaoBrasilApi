using AutoMapper;
using Dtos;
using Models;

namespace Mappings
{
    public class BancoMapping : Profile
    {
        public BancoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<BancoResponse, Banco>();
            CreateMap<Banco, BancoResponse>();
        }
    }
}