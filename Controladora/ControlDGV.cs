using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Entidades;
using System.Collections.Generic;
using System.Data;

namespace Controladora
{
    public class ControlDGV
    {
       
            private ModDGV modDGV = new ModDGV();

            public List<string> ObtenerNombresVendedores(int IDROL)
            {
                return modDGV.LoadNombreVendedor(IDROL);
            }
        public DataTable ObtenerPedido(int DNI)
        {
            return modDGV.ObtenerPedidos(DNI);
        }
        public DataTable ObtenerPedidoPorFecha(int DNI, DateTime fechaInicio, DateTime fechaFin)
        {
            return modDGV.ObtenerPedidosPorFecha(DNI, fechaInicio, fechaFin);
        }

        public DataTable ObtenerCompraPorFechaYEstado(int DNI, DateTime fechaInicio, DateTime fechaFin, int Estado)
        {
            return modDGV.ObtenerComprasPorFechaYEstado(DNI, fechaInicio, fechaFin, Estado);
        }
        public DataTable ObtenerCompra(int DNI, int Estado)
        {
            return modDGV.ObtenerCompras(DNI, Estado);
        }

    }
}
