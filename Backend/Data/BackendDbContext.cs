using System.Data.Common;
using System.Runtime.Serialization;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class BackendDbContext : DbContext
    {
        public BackendDbContext(DbContextOptions<BackendDbContext> options) : base(options) { }

        public DbSet<Bodega> Bodegas { get; set; }
        public DbSet<Vino> Vinos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bodega>().ToTable("Bodegas");

            modelBuilder.Entity<Bodega>().HasData(
                new Bodega
                {
                    Id = 1,
                    Nombre = "Lavero",
                    Ecologica = true,
                    Localizacion = "Toledo",
                    Activa = true


                },
                new Bodega
                {
                    Id = 2,
                    Nombre = "CincoVillas",
                    Ecologica = false,
                    Localizacion = "Rioja",
                    Activa = true

                },
                new Bodega
                {
                    Id = 3,
                    Nombre = "Zierzo",
                    Ecologica = true,
                    Localizacion = "Zaragoza",
                    Activa = true

                }
            );

            modelBuilder.Entity<Vino>().ToTable("Vinos");

            modelBuilder.Entity<Vino>().HasData(
                new Vino
                {
                    Id = 1,
                    BodegaId = 2,
                    Nombre = "Ramon Bilbo",
                    Tipo = "Tinto",
                    Año = new DateTime(2023, 01, 01),
                    Graduacion = 15.5,
                    Precio = 10.5,
                    Stock = 100,
                    NombreBodega = "CincoVillas"
                    

                },
                 new Vino
                 {
                        Id = 2,
                        BodegaId = 1,
                        Nombre = "Rosetti",
                        Tipo = "Rosado",
                        Año = new DateTime(2018, 08, 02),
                        Graduacion = 10.5,
                        Precio = 17.5,
                        Stock = 50,
                        NombreBodega = "Lavero"

                 },
                 new Vino
                 {
                        Id = 3,
                        BodegaId = 3,
                        Nombre = "Nieves",
                        Tipo = "Blanco",
                        Año = new DateTime(2024, 10, 01),
                        Graduacion = 9.5,
                        Precio = 11.2,
                        Stock = 80,
                        NombreBodega = "Zierzo"

                 },
                 new Vino
                 {
                        Id = 4,
                        BodegaId = 1,
                        Nombre = "Swarser",
                        Tipo = "Espumoso",
                        Año = new DateTime(2025, 01, 01),
                        Graduacion = 8.5,
                        Precio = 5.5,
                        Stock = 150,
                        NombreBodega = "Lavero"

                 }
            );

        }
        
    }
}
