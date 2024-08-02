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
        private static ControlDGV _instance;
        private static readonly object _lock = new object();
        private ModDGV modDGV = new ModDGV();

        private ControlDGV()
        {
        }
        public static ControlDGV Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ControlDGV();
                    }
                    return _instance;
                }
            }
        }

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

        public DataTable ObtenerInfoAuditoria()
        {
            return modDGV.ObtenerInfoAuditoria();
        }

        public DataTable ObtenrInfoAuditoriaPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            return modDGV.ObtenerInfoAuditoriaPorFecha(fechaInicio, fechaFin);
        }

        public DataTable ObtenerDetallesAuditoria(string auditoriaID)
        {
            return modDGV.ObtenerDetallesAuditoria(auditoriaID);
        }

        public DataTable ObtenerTiposDeComprobante(int vendedorID, DateTime fechaInicio, DateTime fechaFin)
        {
            return modDGV.ObtenerTiposDeComprobante(vendedorID, fechaInicio, fechaFin);
        }

        public DataTable ObtenerMetodosDeCobro(int vendedorID, DateTime fechaInicio, DateTime fechaFin)
        {
            return modDGV.ObtenerMetodosDeCobro(vendedorID, fechaInicio, fechaFin);
        }


    }
}
