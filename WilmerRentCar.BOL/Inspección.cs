using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilmerRentCar.BOL
{
    public class Inspección : BaseEntity
    {

        public int VehiculoId { get; set; }
        public int ClienteId { get; set; }
        public int EmpleadoId { get; set; }
        public string CantidadCombustible { get; set; }
        public DateTime FechaInspeccion { get; set; }
        public bool Ralladuras { get; set; }
        public bool GomaRepuesta { get; set; }
        public bool Gato { get; set; }
        public bool RoturaCristal { get; set; }
        public bool Goma1 { get; set; }
        public bool Goma2 { get; set; }
        public bool Goma3 { get; set; }
        public bool Goma4 { get; set; }


        public Vehículo Vehiculo { get; set; }
        public Clientes Cliente { get; set; }
        public Empleado Empleado { get; set; }


    }
}
