using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilmerRentCar.BOL
{
    public class Clientes : BaseEntity {
        public string TarjetaCredito { get; set; }
        public int LimiteCredito { get; set; }

        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
    }
}
