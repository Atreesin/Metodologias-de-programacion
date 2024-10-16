using Practica_6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_6.Classes.Command
{
    internal class OrdenLlegaAlumno : OrdenEnAula2
    {
        private Aula aula;
        
        public OrdenLlegaAlumno(Aula a)
        {
            this.aula = a;
        }

        public void ejecutar(Comparable comparable)
        {
            this.aula.nuevoAlumno((IAlumno)comparable);
        }
    }
}
