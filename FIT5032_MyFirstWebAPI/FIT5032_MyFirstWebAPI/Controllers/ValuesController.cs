using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FIT5032_MyFirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //GET:api/<valuesController>
        [HttpGet]
        public IEnumerable<String> Get()
        {
            return new[] { "value1", "value2" };
        }
        //GET api/<valuescontroller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        //POST  api/<valuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }
        //PUT  api/<valuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) { 
        }

        //DELETE  api/<valuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }

    }
}
