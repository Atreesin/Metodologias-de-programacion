using Practica_4.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4.Classes
{
    public class Diccionario : Conjunto, Coleccionable, Iterable
    {
        private List<ClaveValor> elementos = new List<ClaveValor>();
        //Iterador iterador;
        
        
        public void agregar(Comparable clave, Comparable valor)
        {
            
            Comparable claveValor = new ClaveValor(clave, valor);
            Iterador iterador = crearIterador();
            
            if (iterador.primero())
            {
                agregar(((ClaveValor)claveValor));
            }
            else
            {
                if (this.pertenece(claveValor))
                {
                    while (!iterador.fin())
                    {
                        if (((ClaveValor)(iterador.actual())).sosIgual(claveValor))
                        {
                            ((ClaveValor)(iterador.actual())).setValor(valor);
                            break;
                        }
                        else
                        {
                            iterador.siguiente();
                        }
                    }
                }
                else
                {
                    agregar(((ClaveValor)claveValor));
                }
                
                /*
                foreach(ClaveValor cv in elementos)
                {
                    if (cv.getClave().sosIgual(((ClaveValor)claveValor).getClave()))
                    {
                        cv.setValor(((ClaveValor)claveValor).getValor());
                    }
                }*/
            }
        }
        public override void agregar(Comparable claveValor)
        {
            this.elementos.Add((ClaveValor)claveValor);
        }

        public Comparable valorDe(Comparable clave)
        {
            Iterador iterador = crearIterador();
            
            while (!iterador.fin())
            {
                if ((((ClaveValor)(iterador.actual())).getClave()).sosIgual(clave))
                {
                    return ((ClaveValor)(iterador.actual())).getValor();
                }
                
                iterador.siguiente();
            }
            /*
            foreach (ClaveValor cv in elementos)
            {
                if (cv.getClave().sosIgual(clave))
                {
                    return cv.getValor();
                }
            }*/
            return null;
        }

        //*********************************************

        public override bool pertenece(Comparable elem)
        {

            Iterador iterador = crearIterador();
            if (!iterador.primero())
            {
                while (!iterador.fin())
                {
                    if (((ClaveValor)(iterador.actual())).sosIgual((ClaveValor)elem))
                    {
                        return true;  
                    }
                    else
                    {
                        iterador.siguiente();
                    }
                }
            }
            
            /*
            foreach (ClaveValor e in this.elementos)
            {
                if (e.sosIgual(((ClaveValor)elem)))
                {
                    return true;
                }
            }*/
            return false;
        }
        public override int cuantos()
        {
            return this.elementos.Count;
        }

        //*********************************************

        public override Iterador crearIterador()
        {
            return new IteradorDeListClaveValor(elementos, this.cuantos());
        }

        //*********************************************
        public override bool contiene(Comparable c)
        {
            Iterador iterador = crearIterador();
            while (!iterador.fin())
            {
                if ( (((ClaveValor)(iterador.actual())).getValor()).sosIgual(((ClaveValor)c).getValor()) )
                {
                    return true;
                }
                else
                {
                    iterador.siguiente();
                }
            }
            /*
            foreach (ClaveValor e in this.elementos)
            {
                if (e.getValor().sosIgual(((ClaveValor)c).getValor() ))
                {
                    return true;
                }
            }*/
            return false; 
        }

        

        public override Comparable maximo()
        {
            Iterador iterador = crearIterador();
            ClaveValor temp = (ClaveValor)iterador.actual();
            while (!iterador.fin())
            {
                if ((((ClaveValor)(iterador.actual())).getValor()).sosMayor(((ClaveValor)temp).getValor()))
                {
                    temp = (ClaveValor)iterador.actual();
                    break;
                }
                else
                {
                    iterador.siguiente();
                }
            }
            /*
            ClaveValor temp = this.elementos[0];

            foreach (ClaveValor c in this.elementos)
            {
                if (c.getValor().sosMayor(temp.getValor()))
                {
                    temp = c;
                }
            }*/
            return temp;
        }

        public override Comparable minimo()
        {
            Iterador iterador = crearIterador();
            ClaveValor temp = (ClaveValor)iterador.actual();
            while (!iterador.fin())
            {
                if ((((ClaveValor)(iterador.actual())).getValor()).sosMenor(((ClaveValor)temp).getValor()))
                {
                    temp = (ClaveValor)iterador.actual();
                    break;
                }
                else
                {
                    iterador.siguiente();
                }
            }
            /*
            ClaveValor temp = this.elementos[0];
            foreach (ClaveValor c in this.elementos)
            {
                if (c.getValor().sosMenor(temp.getValor()))
                {
                    temp = c;
                }
            }*/
            return temp;
        }
        
    }
}
