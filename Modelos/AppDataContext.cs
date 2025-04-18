using API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Namespace
{
    public class AppDataContext : DbContext
    {
        public DbSet<Prato> Pratos { get; set; }
        public DbSet<Restaurante> Restaurantes { get; set; }

        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurante>().HasData(
                new Restaurante() { Id = 1, Nome = "Restaurante A", Endereco = "Rua A, 123", Telefone = "1234-5678" },
                new Restaurante() { Id = 2, Nome = "Restaurante B", Endereco = "Rua B, 456", Telefone = "8765-4321" }
            );

            modelBuilder.Entity<Prato>().HasData(
                new Prato() { Id = 1, Nome = "Prato 1", Descricao = "Descrição do Prato 1", Preco = 19.99m, RestauranteId = 1 },
                new Prato() { Id = 2, Nome = "Prato 2", Descricao = "Descrição do Prato 2", Preco = 29.99m, RestauranteId = 2 }
            );
        }
    }
}
