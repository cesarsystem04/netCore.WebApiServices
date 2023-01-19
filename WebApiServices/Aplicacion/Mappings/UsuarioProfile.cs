using Aplicacion.Security;
using AutoMapper;
using Domain.Entities.AppServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Mappings
{
    public  class UsuarioProfile : Profile
    {

        public UsuarioProfile() 
        {
            CreateMap<Usuario, GetUsuarioResponse>().ReverseMap();
        }

    }
}
