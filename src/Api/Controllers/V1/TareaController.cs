using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PickingWSApi.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        // GET: api/<TareaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };

        }

        // GET api/<TareaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        [HttpGet("busqueda/{nombre}")]
        public string GetNombre(string nombre)
        {
            return "nombre: "+nombre;
        }

        // POST api/<TareaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TareaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TareaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
