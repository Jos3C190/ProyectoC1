using Microsoft.EntityFrameworkCore;
using ProyectoC1.Models;

namespace ProyectoC1.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Alumno> Alumnos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>().HasKey(a => a.AlumnoId); 
            base.OnModelCreating(modelBuilder);
        }
    }
}
