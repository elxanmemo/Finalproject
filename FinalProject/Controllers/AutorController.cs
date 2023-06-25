using BLL.Abstract;
using DTOs.Autor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly IAutorServices _services;
        public AutorController(IAutorServices services)
        {
                _services=services;
        }
        [HttpPost]
        public IActionResult Get([FromBody] AutorToGetDto dto)
        
        {
            if (_services.Get(dto))
            {
                return Ok(new { message = "Login successful!" });
            }
            else
            {
                return Unauthorized(new { message = "Invalid username or password" });
            }
        
        
        }
        [HttpPost("Login")]
        public IActionResult Add([FromBody] AutorRegistrationAddDto dto)
        {
           

            if (_services.Add(dto))
            {
                return Ok(new { message = "Sign Up successful!" });
            }
            else
            {
                return Unauthorized(new { message = "Username or password is already exists" });
            }
        }
    }
}
