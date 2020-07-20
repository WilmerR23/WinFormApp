using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilmerRentCar.BOL
{
    public class Empleado : BaseEntity
    {
        public string TandaLabor { get; set; }
        public string PorCientoComision { get; set; }
        public DateTime FechaIngreso { get; set; }

        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
    }
}
