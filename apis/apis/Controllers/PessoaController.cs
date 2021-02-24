using apis.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace apis.Controllers
{
    [Route("api/pessoa")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly Contexto contexto;

        public PessoaController(Contexto contexto)
        {
            this.contexto = contexto;
        }

        [HttpGet("pessoa/{id}")]
        public Pessoa ObterPessoa(int id)
        {
            var retorno = this.contexto.Pessoa.Where(a => a.PessoaId == id)
                .Select(a => new Pessoa
                {
                    Endereco = a.Endereco,
                    PessoaId = a.PessoaId,
                    EnderecoId = a.EnderecoId,
                    Nome = a.Nome
                }).FirstOrDefault();
            return retorno;
        }
    }
}
