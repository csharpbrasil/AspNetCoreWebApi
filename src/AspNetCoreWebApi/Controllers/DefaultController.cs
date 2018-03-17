using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    public class DefaultController : Controller
    {
        [HttpGet, Route("get")]
        public IActionResult Get()
        {
            var model_exemplo = new
            {
                success = true
            };

            return Ok(model_exemplo);
        }

        [HttpPost, Route("post")]
        public IActionResult Post([FromBody] object valor)
        {
            var model_exemplo = new
            {
                success = true,
                value = valor
            };

            return Ok(model_exemplo);
        }
    }
}
