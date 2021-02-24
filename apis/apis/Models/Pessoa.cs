namespace apis.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public int? EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
    }
}
