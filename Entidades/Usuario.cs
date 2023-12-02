using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int DNI { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }

        public int Telefono { get; set; }
        public string Password { get; set; }
        
        public string Direction { get; set; }
        public int ID_Rol { get; set; }
    }
}
