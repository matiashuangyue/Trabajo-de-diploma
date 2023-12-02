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
        Modelo.ModUsuario User = new Modelo.ModUsuario();
        public bool Validar(Usuario usuario)
        {
            return User.login(usuario);
        }
    }
}
