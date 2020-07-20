using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilmerRentCar.BOL.Dtos
{
    public class EmpleadoDto : BaseEntityDto
    {
        public string TandaLabor { get; set; }
        public string PorCientoComision { get; set; }
        public DateTime FechaIngreso { get; set; }

        public int PersonaId { get; set; }
        public PersonaDto Persona { get; set; }
    }
}
