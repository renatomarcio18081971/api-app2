using System.Collections.Generic;
using System.Linq;
using apis.Models;
using Microsoft.AspNetCore.Mvc;

namespace apis.Controllers
{
    [Route("api/ofertas")]
    [ApiController]
    public class OfertasController : ControllerBase
    {
        private readonly Contexto contexto;

        public OfertasController(Contexto contexto)
        {
            this.contexto = contexto;
        }

        //GET: api/Ofertas
        [HttpGet()]
        public ICollection<Ofertas> ObterOfertas()
        {
            var retorno = contexto.Ofertas.Select(a => new Ofertas
            {
                Anunciante = a.Anunciante,
                Categoria = a.Categoria,
                Descricao_Oferta = a.Descricao_Oferta,
                Destaque = a.Destaque,
                Id = a.Id,
                Titulo = a.Titulo,
                Valor = a.Valor,
                Imagens = a.Imagens
            }).ToList();
            return retorno;
        }

        //GET: api/Ofertas/5
        [HttpGet("{id}")]
        public Ofertas ObterOfertas(int id)
        {
            var retorno = contexto.Ofertas.Where(a => a.Id == id)
                                          .Select(a => new Ofertas
                                          {
                                             Anunciante = a.Anunciante,
                                             Categoria = a.Categoria,
                                             Descricao_Oferta = a.Descricao_Oferta,
                                             Destaque = a.Destaque,
                                             Id = a.Id,
                                             Titulo = a.Titulo,
                                             Valor = a.Valor,
                                             Imagens = a.Imagens
                                          }).FirstOrDefault();
            return retorno;
        }

        //GET: api/Ofertas/{categoria}/categoria
        [HttpGet("{categoria}/categoria")]
        public ICollection<Ofertas> ObterOfertasPorCategoria(string categoria)
        {
            var retorno = contexto.Ofertas.Where(a => a.Categoria.Contains(categoria))
                                          .Select(a => new Ofertas
                                          {
                                              Anunciante = a.Anunciante,
                                              Categoria = a.Categoria,
                                              Descricao_Oferta = a.Descricao_Oferta,
                                              Destaque = a.Destaque,
                                              Id = a.Id,
                                              Titulo = a.Titulo,
                                              Valor = a.Valor,
                                              Imagens = a.Imagens
                                          }).ToList();
            return retorno;
        }

        [HttpGet("{descricao}/descricaooferta")]
        public ICollection<Ofertas> ObterOfertasPorDescricaoDeOfertas(string descricao)
        {
            var retorno = contexto.Ofertas.Where(o => o.Descricao_Oferta.Contains(descricao)).ToList();
            return retorno;
        }

        // POST: api/Ofertas
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Ofertas/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
