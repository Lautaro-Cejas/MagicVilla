using AutoMapper;
using MagicVillaAPI.Modelos;
using MagicVillaAPI.Modelos.Dto;

namespace MagicVillaAPI
{
    public class MappingConfig:Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>().ReverseMap();
            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();

            CreateMap<NumeroVilla, NumeroVillaDTO>().ReverseMap();
            CreateMap<NumeroVilla, NumeroVillaCreateDTO>().ReverseMap();
            CreateMap<NumeroVilla, NumeroVillaUpdateDTO>().ReverseMap();
        }
    }
}
