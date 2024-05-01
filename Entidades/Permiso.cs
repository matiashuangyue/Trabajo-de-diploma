using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Permiso
    {
        // Propiedades de la clase Permiso
        public int ID { get; set; } // Identificador único del permiso
        public string Nombre { get; set; } // Nombre del permiso

        // Constructor de la clase Permiso
        public Permiso(int id, string nombre)
        {
            ID = id;
            Nombre = nombre;
        }
    }
}
