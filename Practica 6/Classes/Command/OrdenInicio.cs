using Practica_6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_6.Classes.Command
{
    public class OrdenInicio : OrdenEnAula1
    {
        public Aula aula;

        public OrdenInicio(Aula a) 
        {
            this.aula = a;
        }

        public void ejecutar()
        {
            this.aula.comenzar();
        }
    }
}
