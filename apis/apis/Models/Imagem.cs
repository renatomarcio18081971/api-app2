namespace apis.Models
{
    public class Imagem
    {
        public int Id { get; set; }
        public string url { get; set; }
        public int OfertaId { get; set; }
        public Ofertas Ofertas { get; set; }
    }
}
