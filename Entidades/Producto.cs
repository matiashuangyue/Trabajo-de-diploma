using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Producto 
    {
        // ATRIBUTOS PRIVADOS
        //
        private int codigo;
        private string name;
        private string descripcion;
        private decimal? price;
        private int stock;
        private int id_estado;

        // PROPIEDADES PÚBLICAS
        //
        public int Codigo { get; set; }
        public string Name { get; set; }
        public string Descripcion { get; set; }
        public decimal ? Price { get; set; }
        public int Stock { get; set; }

        public int ID_Estado { get; set; }

    }
}
