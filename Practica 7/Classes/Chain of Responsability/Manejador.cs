using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_7.Classes.Chain_of_Responsability
{
    public abstract class Manejador
    {
        protected Manejador sucesor;

        protected Manejador(Manejador m)
        {
            this.sucesor = m;
        }

        //***********************************************//
        //*********         Por teclado      ************//
        //***********************************************//
        public virtual int numeroPorTeclado()
        {
            if(sucesor != null)
            {
                return sucesor.numeroPorTeclado();
            }
            else
            {
                return -1;
            }
        }

        public virtual string stringPorTeclado()
        {
            if(sucesor != null)
            {
                return sucesor.stringPorTeclado();
            }
            else
            {
                return null;
            }
        }


        //***********************************************//
        //*********         Aleatorios       ************//
        //***********************************************//
        public virtual int numeroAleatorio(int max)
        {
            if (sucesor != null)
            {
                return sucesor.numeroAleatorio(max);
            }
            else
            {
                return -1;
            }
        }

        public virtual int numeroAleatorioSinLimite()
        {
            if (sucesor != null)
            {
                return sucesor.numeroAleatorioSinLimite();
            }
            else
            {
                return -1;
            }
        }

        public virtual string stringAleatorio(int cantidad)
        {
            if (sucesor != null)
            {
                return sucesor.stringAleatorio(cantidad);
            }
            else
            {
                return null;
            }
        }

        //***********************************************//
        //*********      Desde Archivo       ************//
        //***********************************************//
        public virtual double numeroDesdeArchivo(double max)
        {
            if (sucesor != null)
            {
                return sucesor.numeroDesdeArchivo(max);
            }
            else
            {
                return -1;
            }
        }

        public virtual string stringDesdeArchivo(int cant)
        {
            if (sucesor != null)
            {
                return sucesor.stringDesdeArchivo(cant);
            }
            else
            {
                return null;
            }
        }
    }
}
