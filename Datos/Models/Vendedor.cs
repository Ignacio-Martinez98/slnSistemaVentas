﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Vendedor:Persona
    {
        public Vendedor()
        {
        }

        public Vendedor(string nombre,string apellido,string dni, decimal comision, int id=0 ) :base(nombre,apellido,dni, id)
        {
            Comision = comision;
        }

        public decimal Comision { get; set; }
    }
}
