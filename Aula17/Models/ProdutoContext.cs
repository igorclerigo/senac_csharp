using Microsoft.EntityFrameworkCore;

namespace Aula17.Models
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options): base(options) { }

        public DbSet<produto>Produtos { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<produto>().ToTable("Produtos");
        }
    }
}
