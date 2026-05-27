using ClassLibraryBus;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassLibraryMd;

namespace WebApplicationAPITreinamento.Controllers
{
    public class CepController : ApiController
    {
        [HttpGet]
        public IEnumerable<MdClass> Get()
        {
            // Retorna a lista de CEPs cadastrados
            var lista = BusClass.Listagem();

            // Verifica se a lista está vazia e retorna um status code apropriado
            return lista;
        }
    }
}
