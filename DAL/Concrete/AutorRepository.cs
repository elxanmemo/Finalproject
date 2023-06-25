
using AutoMapper;
using DAL.Abstract;
using DAL.DataContext;
using DTOs.Autor;
using Entity.Entities;
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

        public bool Add(User user)
        {
            if (!_context.Users.Any(x => x.UserName == user.UserName && x.Password == user.Password))
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return true;

            }
            return false;
           
            
            


        }

        public bool Get(AutorToGetDto dto)
        {
           return _context.Users.Any(x=>x.UserName==dto.UserName && x.Password==dto.Password);

         
            
        }
    }
}
