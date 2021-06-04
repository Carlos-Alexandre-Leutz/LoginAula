using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minhaAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
       

        [HttpPost("logar")]
        public IActionResult Login([FromBody] LoginDto dto)
        {


            var email = "teste@teste.com";
            var senha = 123;

            if (dto.email == email && dto.senha == senha)
            {
                var guid = Guid.NewGuid();
                return Ok(guid);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
