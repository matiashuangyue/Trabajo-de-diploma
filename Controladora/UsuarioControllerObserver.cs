using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class UsuarioControllerObserver
    {
        private ControlUsuario controlUsuario = ControlUsuario.Instance;
        public UsuarioControllerObserver()
        {
            // Attach the observer
            controlUsuario.Attach(new EmailNotifier());
        }
        public void ModificarUsuario(Usuario usuario)
        {
            controlUsuario.ModificarUsuario(usuario);
        }


    }
}
