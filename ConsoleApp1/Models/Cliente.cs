using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Cliente
    {
        
        public Int32 Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public DateTime? FechaNacimiento { get; set; }
        
        public Boolean? Estado { get; set; } 

    }
}
