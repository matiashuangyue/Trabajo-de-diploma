using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetallePedido
    {
        // ATRIBUTOS PRIVADOS
        //
        private long detalleID;
        private long id_pedido;
        private int id_producto;
        private int cantidad;
        private decimal precioVenta;
        private decimal cantidadPrecio;

        // PROPIEDADES PÚBLICAS
        //


        public long DetalleID { get; set; }
        public long ID_Pedido { get; set; }
        public int ID_Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal CantidadPrecio { get; set; }

    }
}
