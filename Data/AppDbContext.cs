using Microsoft.EntityFrameworkCore;

namespace SisCit_System.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Models.Servicio> Servicios { get; set; }
        public DbSet<Models.Usuario> Usuarios { get; set; }
        public DbSet<Models.Negocio> Negocios { get; set; }
        public DbSet<Models.Cita> Citas { get; set; }
    }
}