using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Modelo;

namespace Controladora
{
    public class ControlInforme
    {
        
       
        private ModInforme modInforme = new ModInforme();
        public DataTable ObtenerProductosMasVendidos(DateTime fechaInicio, DateTime fechaFin)
        {
            return modInforme.ObtenerProductosMasVendidos(fechaInicio, fechaFin);
        }

        public DataTable ObtenerVentasPorVendedor(DateTime fechaInicio, DateTime fechaFin)
        {
            return modInforme.ObtenerVentasPorVendedor(fechaInicio, fechaFin);
        }

        public DataTable ObtenerVentaPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            return modInforme.ObtenerVentasPorFecha( fechaInicio,  fechaFin);
        }

        public DataTable ObtenerMargenesDeGanancia(DateTime fechaInicio, DateTime fechaFin)
        {
            return modInforme.ObtenerMargenesDeGanancia(fechaInicio, fechaFin);
        }

    }
}
