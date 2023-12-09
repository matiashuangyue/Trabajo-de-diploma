using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Entidades;
using System.Collections.Generic;

namespace Controladora
{
    public class ControlDGV
    {
       
            private ModDGV modeloNombreVendedor = new ModDGV();

            public List<string> ObtenerNombresVendedores()
            {
                return modeloNombreVendedor.LoadNombreVendedor();
            }
        
    }
}
