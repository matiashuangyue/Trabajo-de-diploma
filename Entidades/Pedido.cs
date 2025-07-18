using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        // ATRIBUTOS PRIVADOS
        //
        private long id_pedido;
        private DateTime fecha;
        private decimal importe;
            
        private decimal netos;
        private int id_vendedor;
        private int id_cliente;
        private int id_estado;
        private string metodoPago; // Nuevo campo para el método de pago
        // PROPIEDADES PÚBLICAS
        //
        public long ID_Pedido { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Importe { get; set; }
        public decimal Netos { get; set; }
        public int ID_Vendedor { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Estado { get; set; }
        public string MetodoPago { get; set; } // Nuevo campo para el método de pago

    }

}
    