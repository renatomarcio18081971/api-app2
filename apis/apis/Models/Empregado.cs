namespace apis.Models
{
    public class Empregado
    {
        public int EmpregadoId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }
        public int TrabalhoId { get; set; }
        public Trabalho Trabalho { get; set; }
    }
}
