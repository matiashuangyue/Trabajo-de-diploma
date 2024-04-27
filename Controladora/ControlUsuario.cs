using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Modelo;

namespace Controladora
{
    public class ControlUsuario
    {
        
       
        private ModUsuario modUsuario = new ModUsuario();
        public bool Validar(Usuario usuario)
        {
            return modUsuario.login(usuario);
        }
        public int GetRoleID(Usuario usuario)
        {
            return modUsuario.GetRoleId(usuario);
        }

        public int GetDNI(string name)
        {
            return modUsuario.GetDNIPorNombre(name);
        }

        public int RegistrarCuenta(Usuario usuario)
        {
            return modUsuario.Registrar(usuario);
        }
        public Usuario BuscarUsuarioPorDNI(int dni)
        {
            return modUsuario.BuscarUsuarioPorDNI(dni);
        }
        public int ModificarUsuario(Usuario usuario)
        {
            return modUsuario.modificarUsuario(usuario);
        }

        public bool validacionID(Usuario usuario)
        {
            return modUsuario.IsValidID(usuario);
        }


        //permisos

        public static List<string> ObtenerPermisosPorRol(int rol)
        {
            ModUsuario modUsuario = new ModUsuario();
            return modUsuario.ObtenerPermisosPorRol(rol);
        }
        public static List<string> ObtenerPermisos()
        {
            ModUsuario modUsuario = new ModUsuario();
            return modUsuario.ObtenerPermisos();
        }

        public static List<string> ObtenerRoles()
        {
            ModUsuario modUsuario = new ModUsuario();
            return modUsuario.ObtenerRoles();
        }

        public int CrearNuevoRol(string rol)
        {
            return modUsuario.CrearNuevoRol(rol);
        }
        public void AgregarPermisoARol(int idRol, string permiso)
        {
            modUsuario.AgregarPermisoARol(idRol, permiso);
        }

    }
}
