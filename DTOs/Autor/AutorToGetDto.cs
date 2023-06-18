using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Autor
{
    public record AutorToGetDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
