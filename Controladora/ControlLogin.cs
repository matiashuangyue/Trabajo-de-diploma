using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Modelo;

namespace Controladora
{
    public class ControlLogin
    {
        Modelo.ModlLogin User = new Modelo.ModlLogin();
        public bool Validar (Usuario usuario)
        {
            return User.login(usuario);
        }
    }
}
