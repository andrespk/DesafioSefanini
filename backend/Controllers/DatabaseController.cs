using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace backend.Controllers
{
    [ApiController]
    public class DatabaseController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public DatabaseController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("api/db/defaultconnection")]
        public IActionResult GetDefaultConnectionString()
        => Ok(_configuration.GetConnectionString("DefaultConnection"));
    }
}