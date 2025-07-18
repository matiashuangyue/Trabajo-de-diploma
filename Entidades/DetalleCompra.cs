using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
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
