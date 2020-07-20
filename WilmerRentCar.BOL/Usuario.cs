﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilmerRentCar.BOL
{
    public class Usuario : BaseEntity
    {
        public string Clave { get; set; }

        public int EmpleadoId { get; set; }

        public Empleado Empleado { get; set; }
    }
}
