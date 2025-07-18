using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Compra
    {
        // ATRIBUTOS PRIVADOS
        //
        private long id_compra;
        private DateTime fecha;
        private decimal importeTotal;
        private int id_proveedor;
        private int dni_usuario;
        private int id_estado;
        // PROPIEDADES PÚBLICAS
        //

        public long ID_Compra { get; set; }
        public DateTime Fecha { get; set; }
        public decimal ImporteTotal { get; set; }
        public int ID_Proveedor { get; set; }
        public int DNI_Usuario { get; set; }
        public int ID_Estado { get; set; }


        // Método para calcular el importe total de la compra




    }

    // Esta clase es un Singleton que mantiene la compra actual
    public class CompraActualContext
        {
        // ATRIBUTOS PRIVADOS
        //
        // Esta clase es un Singleton que mantiene la compra actual
        // para evitar crear múltiples instancias de Compra en la aplicación.

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
        // ATRIBUTOS PRIVADOS
        //
        private long id_compra;
        private int id_producto;
        private int cantidad;
        private decimal precioUnitario;
        private string nombreProducto;
        // PROPIEDADES PÚBLICAS
        //

        public long ID_Compra { get; set; }
        public int ID_Producto { get; set; }

        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        public string NombreProducto { get; set; }
        public decimal PrecioTotal
        {
            get
            {
                return Cantidad * PrecioUnitario;
            }
        }
    }
}