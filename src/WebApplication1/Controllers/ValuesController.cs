
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using WebApplication1.ServiceInterface;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IDependenceyInjectedService _Service;

        public ValuesController(IDependenceyInjectedService service)
        {
            _Service = service;

        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _Service.GetValues();
            //return new string[] { "value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8"};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
