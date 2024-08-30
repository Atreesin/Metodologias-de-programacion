using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2.Interfaces
{
    public interface Iterador
    {
        Comparable actual();
        void anterior();
        void siguiente();
        bool primero();
        bool fin();
    }
}
