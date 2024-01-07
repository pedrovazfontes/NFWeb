using Microsoft.EntityFrameworkCore;
using WebNotas.Data.Configurations;
using WebNotas.Models;

namespace WebNotas.Data
{
    public class AplicationContext : DbContext
    {
        public DbSet<NF> Notas { get; set; }
        public AplicationContext() { }

        public AplicationContext(DbContextOptions<AplicationContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-7PE6O6G\\SQLEXPRESS;Database=NotasFiscais;Integrated Security=true; Trusted_Connection =true;TrustServerCertificate=true");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof (AplicationContext).Assembly);
        
        }
    }
}
