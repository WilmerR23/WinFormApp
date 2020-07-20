using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilmerRentCar.BOL.Dtos
{
    public class InspeccionDto : BaseEntityDto
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


        public VehículoDto Vehiculo { get; set; }
        public ClientesDto Cliente { get; set; }
        public EmpleadoDto Empleado { get; set; }

    }
}
