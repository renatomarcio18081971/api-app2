using apis.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace apis.Controllers
{
    [Route("api/imagem")]
    [ApiController]
    public class ImagemController : ControllerBase
    {
        private readonly Contexto contexto;

        public ImagemController(Contexto contexto)
        {
            this.contexto = contexto;
        }

        //GET: api/imagem
        [HttpGet("Imagens/{ofertaId}")]
        public ICollection<Imagem> ObterImagensAPartirDeOferta(int ofertaId)
        {
            var retorno = contexto.Imagem.Where(a => a.OfertaId == ofertaId).ToList();
            return retorno;
        }

    }
}
