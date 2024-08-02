using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Modelo;

namespace Controladora
{
    public class ControlCompra
    {
        private static ControlCompra _instance;
        private static readonly object _lock = new object();
        private ModCompra modeloCompra = new ModCompra();

        private ControlCompra()
        {
        }
        public static ControlCompra Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ControlCompra();
                    }
                    return _instance;
                }
            }
        }
        public int CerrarCompra(Compra compra)
        {
            return modeloCompra.CerrarCompra(compra);
        }
        public int insertID(Compra compra)
        {
            return modeloCompra.insertarid(compra);
        }
        public int AddDetalle(DetalleCompra detalle)
        {
            return modeloCompra.RegistrarDetalleCompra(detalle);
        }
        public void ver(DetalleCompra detalle)
        {
            try
            {
                var resultado = modeloCompra.paraverQuepasa(detalle);

                if (resultado.Item1 == 1)
                {
                    // Operación exitosa
                    Console.WriteLine("Detalle de compra agregado correctamente.");
                }
                else
                {
                    // Hubo un error, puedes acceder a la excepción así:
                    Exception excepcion = resultado.Item2;
                    Console.WriteLine("Error al agregar detalle de compra: " + excepcion.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general en la controladora: " + ex.Message);
            }
        }

        public int CambiarEstadoCompra(long ID, int NuevoEstado)
        {
            return modeloCompra.CambiarEstadoCompra(ID,NuevoEstado);
        }

        public int EliminarDetalleCompra(long idCompra, int idProducto)
        {
            return modeloCompra.EliminarDetalleCompra(idCompra, idProducto);
        }

        public List<DetalleCompra> ObtenerDetallesCompra(long idCompra)
        {
            return modeloCompra.ObtenerDetallesCompra(idCompra);
        }


    }
}
