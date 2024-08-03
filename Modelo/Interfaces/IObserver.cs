using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Interfaces
{
    public interface IObserver
    {
        //Metodo que se encarga de actualizar la informacion de un usuario
        //Recibe un usuario como parametro
        //No devuelve nada
        void Update(Usuario usuario);
        
    }
}
