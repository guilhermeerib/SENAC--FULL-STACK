using Exo.WebApi.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


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
                // Essa string de conexão depende da sua maquina
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;"
                + "Database=ExoApi;Trusted_Connection=True;");
                // Exemplo 1 de string de conexão;
                // User ID=sa ; Password=1234;Server=localhost;Database=ExoApi;
                // *Trusted_connection=False;

                // Exemplo 2 de string de conexão;
                // Server=localhost\\SQLEXPRESS;Database=ExoApi;Trusted_Connection=True;

            }
        }

        public DbSet<Projeto> Projetos { get; set; }
    }
}