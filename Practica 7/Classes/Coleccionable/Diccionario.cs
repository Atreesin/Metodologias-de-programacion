using Practica_7.Interfaces;
using System.Collections.Generic;


namespace Practica_7.Classes
{
    public class Diccionario : Conjunto, Coleccionable, Iterable, Ordenable
    {
        private List<ClaveValor> elementos = new List<ClaveValor>();

        
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
                
                
            }
        }
        public override void agregar(Comparable claveValor)
        {
            this.elementos.Add((ClaveValor)claveValor);
            if (cuantos() == 1 && ordenInicio != null)
            {
                ordenInicio.ejecutar();
            }
            if (ordenLlegaAlumno != null)
            {
                ordenLlegaAlumno.ejecutar(claveValor);
            }
            if (ordenAulaLlena != null && cuantos() == 40)
            {
                ordenAulaLlena.ejecutar();
            }
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
            
            return temp;
        }

        
    }
}
