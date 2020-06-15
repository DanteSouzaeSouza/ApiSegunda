using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiSegunda.Controllers
{
    public class FuncionarioController : ApiController
    {
        // GET api/funcionario
        public System.Collections.IEnumerable Get()
        {
            return new string[] {"value 1", "value 2"};
        }
        // GET api/funcionario/5
        public string Get(int id)
        {
            return "value";
        }
        // POST api/funcionario
        public void Post([FromBody] string value)
        {
        }
        // PUT api/funcionario/5
        public void Put(int id, [FromBody] string value)
        {
        }
        // DELETE api/funcionario/5
        public void Delete(int id)
        {
        }
    }
}
