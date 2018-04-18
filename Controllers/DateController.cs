using System;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcore_docker_sample.Controllers
{
    [Route("api/[controller]")]
    public class DateController : Controller
    {
        [HttpGet]
        public DateTime Utc()
        {
            return DateTime.UtcNow;
        }

        [HttpGet("local")]
        public DateTime Get()
        {
            return DateTime.Now;
        }
    }
}