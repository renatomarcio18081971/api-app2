using apis.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace apis.Controllers
{
    [Route("api/empregados")]
    [ApiController]
    public class EmpregadosController : ControllerBase
    {

        private readonly Contexto contexto;

        public EmpregadosController(Contexto contexto)
        {
            this.contexto = contexto;
        }


        [HttpGet("emprego/{id}")]
        public Empregado ObterEmprego(int id)
        {
            var retorno = contexto.Empregado.Where(a => a.EmpregadoId == id).FirstOrDefault();
            return retorno;
        }
    }
}
