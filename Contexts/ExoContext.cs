using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {
        }

        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Atualize a string de conexão com os detalhes da sua máquina e banco de dados
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=ExoApi;Trusted_Connection=True;");
            }
        }

        // Inclua o DbSet para a entidade Usuario e Projeto
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
    }
}
