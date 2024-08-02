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
        private static ControlBackUp _instance;
        private static readonly object _lock = new object();
        private ModBackUpRestore modeloBackUp = new ModBackUpRestore();

        private ControlBackUp()
        {
        }
        public static ControlBackUp Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ControlBackUp();
                    }
                    return _instance;
                }
            }
        }
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
