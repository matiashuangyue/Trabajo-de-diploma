using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        public long ID_Pedido { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Importe { get; set; }
        public decimal Netos { get; set; }
        public int ID_Vendedor { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Estado { get; set; }

    }
    public class DetallePedido
    {
        public long DetalleID { get; set; }
        public long ID_Pedido { get; set; }
        public int ID_Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal CantidadPrecio { get; set; }

    }
}
    