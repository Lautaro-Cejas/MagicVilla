using AutoMapper;
using MagicVIllaAPI.Modelos;
using MagicVIllaAPI.Modelos.Dto;

namespace MagicVillaAPI
{
    public class MappingConfig:Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>().ReverseMap();
            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();
        }
    }
}
