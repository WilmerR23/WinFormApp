using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilmerRentCar.BOL
{
    public class Persona : BaseEntity
    {
        public string Cedula { get; set; }
        public int TipoPersonaId { get; set; }
        public TipoPersona TipoPersona { get; set; }
    }
}
