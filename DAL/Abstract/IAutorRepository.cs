using DTOs.Autor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IAutorRepository
    {
        public bool Get(AutorToGetDto dto);

    }
}
