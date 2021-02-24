using System;
using System.Collections.Generic;

namespace apis.Models
{
    public class Ofertas
    {
        public int Id { get; set; }
        public string Categoria { get; set; }
        public string Titulo { get; set; }
        public string Descricao_Oferta { get; set; }
        public string Anunciante { get; set; }
        public decimal Valor { get; set; }
        public Boolean Destaque { get; set; }
        public ICollection<Imagem> Imagens { get; set; }
    }
}
