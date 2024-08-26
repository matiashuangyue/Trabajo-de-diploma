using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Permiso: Componente
    {
        public override string ToString()
        {
            return Nombre;
        }
        public Permiso() { }
        public Permiso(string nombre)
        {
            Nombre = nombre;
        }

    }
}
