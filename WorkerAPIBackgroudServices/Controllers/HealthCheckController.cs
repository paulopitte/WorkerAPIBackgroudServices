using Microsoft.AspNetCore.Mvc;
using System;

namespace WorkerAPIBackgroudServices.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
     
        [HttpGet]
        public IActionResult Get()
        {
            return Ok($"HealthCheck - {DateTime.UtcNow:o}" );
        }
    }
}
