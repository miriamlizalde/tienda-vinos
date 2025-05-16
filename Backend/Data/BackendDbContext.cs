using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class BackendDbContext : DbContext
    {
        public BackendDbContext(DbContextOptions<BackendDbContext> options) : base(options)

        public DbSet<Bodega> Bodegas { get; set; }
        public DbSet<Vino> Vinos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bodega>().ToTable("Bodegas");

            modelBuilder.Entity<Bodega>().HasData(
                new Bodega
                {

                },
                new Bodega
                {

                },
                new Bodega
                {
                    
                }
            )
        }
        
    }
}
