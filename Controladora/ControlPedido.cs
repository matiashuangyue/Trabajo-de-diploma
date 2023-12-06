using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;
using Entidades;

namespace Controladora
{
    public class ControlPedido
    {
        private ModPedido modeloPedido = new ModPedido();
        
        
        public DataTable ObtenerDetallePedido(DetallePedido detallePedido)
        {
            return modeloPedido.ArrancarPedido(detallePedido);
        }
        public int registrarDetalles(DetallePedido detallePedido)
        {
            return modeloPedido.RegistrarDetalleCompra(detallePedido);
        }
        public int inserID(Pedido pedido)
        {
            return modeloPedido.insertarid(pedido);
        }
    }
}
