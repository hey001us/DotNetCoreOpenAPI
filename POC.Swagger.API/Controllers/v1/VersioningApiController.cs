using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace POC.Swagger.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class VersioningApiController : ControllerBase
    {
        [HttpGet("~/GetValue")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1 PNZ", "value2 PNZ2" };
        }

        [HttpGet("~/GetValueById/{id}")]
        public string Get(int id)
        {
            return "My Value by Id";
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
