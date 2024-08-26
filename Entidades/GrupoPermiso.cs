using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GrupoPermiso: Componente
    {
        public List<Componente> Permisos { get; set; }

        public GrupoPermiso()
        {
            Permisos = new List<Componente>();
        }

        public void Agregar(Componente permiso)
        {
            Permisos.Add(permiso);
        }

        public void Quitar(Componente permiso)
        {
            Permisos.Remove(permiso);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Nombre);
            foreach (Componente permiso in Permisos)
            {
                sb.AppendLine(permiso.ToString());
            }
            return sb.ToString();
        }
    }
}
