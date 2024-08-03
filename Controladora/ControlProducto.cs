using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Entidades;

namespace Controladora
{
    public class ControlProducto
    {
        private static ControlProducto _instance;
        private static readonly object _lock = new object();
        Modelo.ModProducto Produc= new ModProducto();

        private ControlProducto()
        {
        }
        public static ControlProducto Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ControlProducto();
                    }
                    return _instance;
                }
            }
        }


        

        public int AddProducto(Producto producto)
        {
            return Produc.agregarProducto(producto);
        }
        public Producto BuscarProductoPorCodigo(Producto producto)
        {
            return Produc.buscarProductoPorCodigo(producto);
        }
        public List<Producto> BuscarProductosPorNombre(string nombre)
        {
            return Produc.BuscarProductosPorNombre(nombre);
        }

        public int ModificarProducto(Producto producto)
        {
            return Produc.modificarProducto(producto);
        }

        public int EliminarProducto(Producto producto)
        {
            return Produc.eliminarProducto(producto);
        }

    }
}
