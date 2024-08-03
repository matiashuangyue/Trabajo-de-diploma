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
        
        void Update(Usuario usuario);//Metodo que se encarga de actualizar la informacion de un usuario


    }
}
