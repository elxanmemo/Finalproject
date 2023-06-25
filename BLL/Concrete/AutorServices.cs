using AutoMapper;
using BLL.Abstract;
using DAL.Abstract;
using DTOs.Autor;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class AutorServices : IAutorServices
    {
        private readonly IMapper _mapper;
        private readonly IAutorRepository _repositor;
        public AutorServices(IAutorRepository repository,IMapper mapper)
        {
            _repositor= repository;
            _mapper= mapper;
        }

        public  bool Add(AutorRegistrationAddDto dto)
        {
           User user= _mapper.Map<User>(dto);
          return _repositor.Add(user);

        }

        public bool Get(AutorToGetDto dto)
        {
            return _repositor.Get(dto);
        }
    }
}
