using Microsoft.EntityFrameworkCore;
using RegistroPrestamo.Entidades;


namespace RegistroPrestamo.DAL{

    public class Contexto: DbContext{

      public DbSet<Prestamo> Prestamo { get; set; }
      public DbSet<Persona> Persona { get; set; }
      public DbSet<Moras> Moras { get; set; }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
          optionsBuilder.UseSqlite(@"Data Source =Data/Prestamo.db");
      }
    }
}