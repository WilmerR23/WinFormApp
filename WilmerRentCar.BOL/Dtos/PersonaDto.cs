using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilmerRentCar.BOL.Dtos
{
    public class PersonaDto : BaseEntityDto
    {
        public string Cedula { get; set; }
        public int TipoPersonaId { get; set; }
        public TipoPersonaDto TipoPersona { get; set; }
    }
}
