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
        public DataTable ObtenerProductosMasVendidos()
        {
            return modInforme.ObtenerProductosMasVendidos();
        }

        public DataTable ObtenerVentasPorVendedor()
        {
            return modInforme.ObtenerVentasPorVendedor();
        }

        public DataTable ObtenerVentaPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            return modInforme.ObtenerVentasPorFecha( fechaInicio,  fechaFin);
        }

        public DataTable ObtenerMargenesDeGanancia()
        {
            return modInforme.ObtenerMargenesDeGanancia();
        }

    }
}
