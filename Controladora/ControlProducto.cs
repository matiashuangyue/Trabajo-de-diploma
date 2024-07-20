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
        Modelo.ModProducto Produc= new ModProducto();
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
