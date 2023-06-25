using AutoMapper;
using DTOs.Autor;
using DTOs.CV;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapper
{
    public class CustomMapper :Profile
    {
        public CustomMapper()
        {
             CreateMap<AutorRegistrationAddDto, User>();
            CreateMap<CVAddDto, CVInfo>();
            CreateMap<CVInfo, CVAddDto>();
        }
    }
}
