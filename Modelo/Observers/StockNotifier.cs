using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Modelo.Interfaces;

namespace Modelo.Observers
{
    public class StockNotifier 
    {
        public void Update(Producto producto)
        {
            if (producto.Stock < 10) // Umbral de stock bajo, por ejemplo 10
            {
                // Enviar alerta o tomar alguna acción
                Console.WriteLine($"Alerta: El stock del producto {producto.Name} es bajo. Stock actual: {producto.Stock}");
            }
        }



    }
}
