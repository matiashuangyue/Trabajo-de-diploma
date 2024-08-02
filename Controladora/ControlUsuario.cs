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

        private static ControlUsuario _instance;
        private static readonly object _lock = new object();
        private ModUsuario modUsuario = new ModUsuario();

        private ControlUsuario()
        {
            // Constructor privado para evitar que se creen instancias fuera de esta clase
        }

        // Propiedad pública estática para obtener la instancia única
        public static ControlUsuario Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ControlUsuario();
                    }
                    return _instance;
                }
            }
        }
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
        public string GetContra(int dni,string mail)
        {
            return modUsuario.GetPasswordPorDniYMail(dni,mail);
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

        public int ObtenerRolID(string rol)
        {
            return modUsuario.ObtenerIdRolPorNombre(rol);
        }

        public int CrearNuevoRol(string rol)
        {
            return modUsuario.CrearNuevoRol(rol);
        }

        public int CrearPermiso(string permiso)
        {
            return modUsuario.CrearNuevoPermiso(permiso);
        }
        public void AgregarPermisoARol(int idRol, string permiso)
        {
            modUsuario.AgregarPermisoARol(idRol, permiso);
        }

        public void ActualizarPermisosPorRol(int idRol, List<string> permisos)
        {
            // Llama al método correspondiente en la capa de modelo (ModUsuario)
            modUsuario.ActualizarPermisosPorRol(idRol, permisos);
        }

        public List<KeyValuePair<int, string>> ObtenerIDyRoles()
        {
            return modUsuario.ObtenerIDyRoles();
        }


    }
}
