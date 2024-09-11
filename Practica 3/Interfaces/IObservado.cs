using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Interfaces
{
    public interface IObservado
    {
        void agregarObservador(IObservador observador);
        void quitarObservador(IObservador observador);
        void notificar();
    }
}
