using Appis.Model;
using Microsoft.EntityFrameworkCore;

namespace Appis.Infraestrutura
{
    public class ConnectionContext : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Secao> Secaos { get; set; }

        public DbSet<Notificacao> Notificacaos { get; set; }

        public DbSet<DeepLinkExtra> DeepLinks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("Server=localhost;" +
            "Port=5432;" +
            "Database=TesteAPI;" +
            "User Id=postgres;" +
            "Password=12345;");
    }
}
