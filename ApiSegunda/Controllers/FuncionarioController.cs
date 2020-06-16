using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Linq;
using ApiSegunda.Models;

namespace ApiSegunda.Controllers
{
    
    public class FuncionarioController : ApiController
    {
        // GET api/funcionario
        public Funcionario[] Get()
        {
            return funcionarios;
        }
        // GET api/funcionario/[:id]
        public Funcionario Get(int id)
        {
            return funcionarios[id];
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
            var list = funcionarios.ToList();
            list.RemoveAt(id);
            funcionarios = list.ToArray();
        }

        private Funcionario[] funcionarios = new Funcionario[]
        {
            new Funcionario("Tangamandápio", 1, "Maria", "RH", "Pereira"),
            new Funcionario("Brasilia", 2, "José", "TI", "da Silva"),
            new Funcionario("BH", 3, "Dante", "TI", "Souza e Souza"),
            new Funcionario("São Luís", 4, "Marcos", "SESMT", "Alencar"),
            new Funcionario("São Paulo", 5, "Lucileide", "Diretoria", "Oliveira")
        };
    }
    
}
