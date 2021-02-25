using apis.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace apis.Controllers
{
    [Route("api/ofertas")]
    [ApiController]
    public class OndeFicarController : ControllerBase
    {
        private readonly Contexto contexto;

        public OndeFicarController(Contexto contexto)
        {
            this.contexto = contexto;
        }

        [HttpGet("ondeficar/{id}")]
        public OndeFicar obterOndeFicar(int id)
        {
            var retorno = contexto.OndeFicar.Where(o => o.Id == id).FirstOrDefault();
            return retorno;
        }
    }
}
