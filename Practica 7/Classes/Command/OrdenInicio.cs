using Practica_7.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_7.Classes.Command
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
