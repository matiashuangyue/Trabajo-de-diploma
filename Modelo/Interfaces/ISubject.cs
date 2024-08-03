using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Interfaces
{
    public interface ISubject
    {
        //Metodo que se encarga de adjuntar un observador
        //Recibe un observador como parametro
        void Attach(IObserver observer);

        //Metodo que se encarga de desadjuntar un observador
        void Detach(IObserver observer);

        //Metodo que se encarga de notificar a los observadores
        //Recibe un usuario como parametro
        void Notify(Usuario usuario);
    }
}
