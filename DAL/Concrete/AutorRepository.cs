
using DAL.Abstract;
using DAL.DataContext;
using DTOs.Autor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class AutorRepository : IAutorRepository
    {
        private readonly MyDataContext _context;
        public AutorRepository(MyDataContext context)
        {
                _context= context;
        }
        public bool Get(AutorToGetDto dto)
        {
           return _context.Users.Any(x=>x.UserName==dto.UserName && x.Password==dto.Password);

         
            
        }
    }
}
