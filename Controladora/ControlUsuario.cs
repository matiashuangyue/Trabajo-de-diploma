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
        
        private Modelo.ModUsuario ModUser = new Modelo.ModUsuario();
        private ModUsuario modUsuario = new ModUsuario();
        public bool Validar(Usuario usuario)
        {
            return ModUser.login(usuario);
        }
        public int GetRoleID(Usuario usuario)
        {
            return ModUser.GetRoleId(usuario);
        }
        public int RegistrarCuenta(Usuario usuario)
        {
            return ModUser.Registrar(usuario);
        }
        public Usuario BuscarUsuarioPorDNI(int dni)
        {
            return modUsuario.BuscarUsuarioPorDNI(dni);
        }

    }
}
