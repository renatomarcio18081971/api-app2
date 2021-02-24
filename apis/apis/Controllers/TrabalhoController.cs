using apis.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace apis.Controllers
{
    [Route("api/trabalho")]
    [ApiController]
    public class TrabalhoController : ControllerBase
    {
        private readonly Contexto contexto;

        public TrabalhoController(Contexto contexto)
        {
            this.contexto = contexto;
        }

        [HttpGet("{id}")]
        public Trabalho Obter(int id)
        {
            var retorno = contexto.Trabalho.Where(t => t.TrabalhoId == id)
                                           .Select(t => new Trabalho
                                           {
                                               TrabalhoId = t.TrabalhoId,
                                               Nome = t.Nome,
                                               Empregados = t.Empregados
                                           }).FirstOrDefault();
            return retorno;
        }

    }
}
