using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        //ATRIBUTOS
        //
        private int dni;
        private string name;
        private string mail;
        private long telefono;
        private string direccion;
        private string password;
        private int id_rol;
        private int id_estado;


        //
        //PROPIEDADES
        //

        public int DNI { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public long Telefono { get; set; }
        public string Direccion { get; set; }
        public string Password { get; set; }
        public int ID_Rol { get; set; }
        public int ID_Estado { get; set; }

     

        
    }
}
