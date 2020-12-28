using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Professor : ControllerBase
    {

        public Professor()
        {
            
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Deu tudo certo porra");
        }
        
    }
}