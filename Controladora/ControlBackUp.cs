using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Modelo;

namespace Controladora
{
    public class ControlBackUp
    {
        private ModBackUpRestore modeloBackUp = new ModBackUpRestore();

        public int RealizarBackUp(string Ruta)
        {
            return modeloBackUp.RealizarBackUp(Ruta);
        }

        public int RealizarRestore(string Ruta)
        {
            return modeloBackUp.RealizarRestore(Ruta);
        }
    }
}
