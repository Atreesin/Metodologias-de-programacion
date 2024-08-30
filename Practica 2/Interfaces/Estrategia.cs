using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2.Interfaces
{
    public interface Estrategia
    {
        bool sosIgual(Comparable a, Comparable b);
        bool sosMenor(Comparable a, Comparable b);
        bool sosMayor(Comparable a, Comparable b);
    }
}
