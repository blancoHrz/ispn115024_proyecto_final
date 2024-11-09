using Microsoft.EntityFrameworkCore;
using ispn115024_proyecto_final.Models;

namespace ispn115024_proyecto_final.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() { }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public int idCliente { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>().HasKey(Cliente => Cliente.idCliente);
        }

        public string nombre { get; set; }

        public string direccion { get; set; }

        public string telefono { get; set; }

        public string documento { get; set; }
        public DbSet<ispn115024_proyecto_final.Models.Cliente> Cliente { get; set; } = default!;
    }
}
