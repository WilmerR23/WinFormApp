using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WilmerRentCar.BOL;

namespace WilmerRentCar.DAL
{
    public class RentCarDbContext : DbContext
    {
        public RentCarDbContext() : base("RentCar") {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove();
        }


        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Clientes> Cliente { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Inspección> Inspección { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Modelo> Modelo { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<RentaDevolucion> RentaDevolucion { get; set; }
        public DbSet<TipoCombustible> TipoCombustible { get; set; }
        public DbSet<TipoPersona> TipoPersona { get; set; }
        public DbSet<TipoVehiculo> TipoVehiculo { get; set; }
        public DbSet<Vehículo> Vehículo { get; set; }

    }
}
