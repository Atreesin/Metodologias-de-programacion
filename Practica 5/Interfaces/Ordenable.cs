using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5.Interfaces
{
    internal interface Ordenable
    {
        void setOrdenInicio(OrdenEnAula1 orden);
        void setOrdenLlegaAlumno(OrdenEnAula2 orden);
        void setOrdenAulaLlena(OrdenEnAula1 orden);
    }
}
