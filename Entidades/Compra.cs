using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Compra
    {
        public long ID_Compra { get; set; }
        public DateTime Fecha { get; set; }
        public decimal ImporteTotal { get; set; }
        public int ID_Proveedor { get; set; }
        public int DNI_Usuario { get; set; }
        public int ID_Estado { get; set; }

     
        // Método para calcular el importe total de la compra
        

       

    } 
    public class CompraActualContext
        {
            private static Compra compraActual;

            public static Compra ObtenerCompraActual()
            {
                if (compraActual == null)
                {
                    // Crear una nueva instancia de Compra si no existe
                    compraActual = new Compra();
                }

                return compraActual;
            }
        }

    public class DetalleCompra
    {

        public long ID_Compra { get; set; }
        public int ID_Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}