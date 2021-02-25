using Microsoft.EntityFrameworkCore;

namespace apis.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Imagem> Imagem { get; set; }
        public DbSet<Ofertas> Ofertas { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Empregado> Empregado { get; set; }
        public DbSet<Trabalho> Trabalho { get; set; }
        public DbSet<OndeFicar> OndeFicar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //relacionamento 0 -> 1
            modelBuilder.Entity<Pessoa>().HasOne(a => a.Endereco).WithOne(a => a.Pessoa).HasForeignKey<Pessoa>(a => a.EnderecoId);
            modelBuilder.Entity<Endereco>().HasOne(a => a.Pessoa).WithOne(a => a.Endereco);

            //relacionamento 1 -> N
            modelBuilder.Entity<Empregado>().HasOne(e => e.Trabalho).WithMany(e => e.Empregados).HasForeignKey(e => e.TrabalhoId);
            modelBuilder.Entity<Trabalho>().HasMany(t => t.Empregados).WithOne(t => t.Trabalho);

            modelBuilder.Entity<Imagem>().HasOne(i => i.Ofertas).WithMany(i => i.Imagens).HasForeignKey(i => i.OfertaId);
            modelBuilder.Entity<Ofertas>().HasMany(o => o.Imagens).WithOne(o => o.Ofertas);

            //relacionamento N -> N

        }

    }
}
