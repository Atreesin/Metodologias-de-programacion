using MetodologíasDeProgramaciónI;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5.Classes
{
    public class IAlumnoComparer : IComparer<Comparable>
    {
        public int Compare(Comparable s1, Comparable s2)
        {
            if (s1.sosIgual(s2))
                return 0;
            else
            if (s1.sosMenor(s2))
                return 1;
            else
                return -1;
        }
    }
}
