﻿using System;
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
        private static ControlPedido _instance;
        private static readonly object _lock = new object();
        private ModPedido modeloPedido = new ModPedido();

        private ControlPedido() { }
        public static ControlPedido Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ControlPedido();
    }
                    return _instance;
                }
            }
        }

        public DataTable ObtenerDetallePedido(DetallePedido detallePedido)
        {
            return modeloPedido.ArrancarPedido(detallePedido);
        }
        public int registrarDetalles(DetallePedido detallePedido)
        {
            return modeloPedido.RegistrarDetallePedido(detallePedido);
        }
        public int inserID(Pedido pedido)
        {
            return modeloPedido.insertarid(pedido);
        }
        public int cerrarPedido(Pedido pedido)
        {
            return modeloPedido.CerrarPedido(pedido);
        }

        public int EliminarDetallePedido(long detalleID)
        {
            return modeloPedido.EliminarDetallePedido(detalleID);
        }


        public long ObtenerUltimoDetalleID()
        {
            return modeloPedido.ObtenerUltimoDetalleID();
        }

        public long EliminarPedido(long pedidoID)
        {
            return modeloPedido.EliminarPedido(pedidoID);
        }

        public void EliminarPedidosInutiles()
        {
            modeloPedido.EliminarPedidosInutiles();
        }
    }
}
