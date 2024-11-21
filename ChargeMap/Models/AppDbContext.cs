using ChargeMap.Models;
using Microsoft.EntityFrameworkCore;

namespace PlanejadorViagens.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Carro> Carros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("Data Source=SeuServidorOracle;User Id=usuario;Password=senha;");
        }
    }
}
