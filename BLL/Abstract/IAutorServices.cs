using BLL.Abstract;
using DAL.Abstract;
using DTOs.Autor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IAutorServices
    {
        public bool Get(AutorToGetDto dto);
        public bool Add(AutorRegistrationAddDto dto);
    }
}
