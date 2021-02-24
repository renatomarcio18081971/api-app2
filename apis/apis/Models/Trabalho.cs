using System.Collections.Generic;

namespace apis.Models
{
    public class Trabalho
    {
        public int TrabalhoId { get; set; }
        public string Nome { get; set; }
        public ICollection<Empregado> Empregados { get; set; }
    }
}
