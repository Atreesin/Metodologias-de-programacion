using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4.Interfaces
{
    public interface IObservador
    {
        void actualizar(IObservado observado);
    }
}
