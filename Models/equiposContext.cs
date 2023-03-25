using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace practicaWEbEquipos.Models
{
    public class equiposContext : DbContext
    {
        public equiposContext (DbContextOptions<equiposContext> options) : base(options)
        { 

        }
        public DbSet<equipos> equipos { get; set; }
        public DbSet<equipos> marcas { get; set; }
        public DbSet<equipos> tipo_equipo { get; set; }
        public DbSet<equipos> estados_equipos { get; set; }
        public DbSet<equipos> estados_reserva { get; set; }
        public DbSet<equipos> carreras { get; set; }
        public DbSet<equipos> facultades { get; set; }
        public DbSet<equipos> reservas { get; set; }
        public DbSet<equipos> usuarios { get; set; }
    }


}
