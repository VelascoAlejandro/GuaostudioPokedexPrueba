using AutoMapper;
using GuaostudioPokedex.DTOs;
using GuaostudioPokedex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuaostudioPokedex.Utilidades
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Entrenador, EntrenadorDTO>().ReverseMap();
            CreateMap<EntrenadorCrearDTO, Entrenador>();
        }
    }
}
