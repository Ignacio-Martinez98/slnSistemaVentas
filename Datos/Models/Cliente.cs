using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Cliente:Persona
    {
        public Cliente(string nombre,string apellido,string dni,int id=0) : base(nombre, apellido, dni, id) { }
    }
}
