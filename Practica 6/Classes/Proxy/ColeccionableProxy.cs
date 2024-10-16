using Practica_6.Classes.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_6.Classes.Proxy
{
    public class ColeccionableProxy : Coleccionable
    {
        private Coleccionable coleccionableReal = null;
        private int queCrear;
        Comparable min = null , max = null;

        /// <summary>
        /// Coleccionable Proxy.
        /// </summary>
        /// <param name="queCrear">
        /// Opcion de Coleccionable a Crear.
        /// <list type="table">
        /// <b>Opciones:</b>
        /// <item>
        /// <description>1 - Pila</description>
        /// </item>
        /// <item>
        /// <description>2 - Cola</description>
        /// </item>
        /// <item>
        /// <description>3 - Coleccion Multiple</description>
        /// </item>
        /// <item>
        /// <description>4 - Conjunto</description>
        /// </item>
        /// <item>
        /// <description>5 - Diccionario</description>
        /// </item>
        /// </list>
        /// </param>
        public ColeccionableProxy(int queCrear)
        {
            this.queCrear = queCrear;
        }

        public void agregar(Comparable c)
        {
            if (coleccionableReal == null)
            {
                coleccionableReal = FabricaDeColeccionables.crearColeccionable(queCrear);
                coleccionableReal.agregar(c);
                this.min = c;
                this.max = c;
            }
            else
            {
                coleccionableReal.agregar(c);
                this.min = coleccionableReal.minimo();
                this.max = coleccionableReal.maximo();
            }
            
        }

        public bool contiene(Comparable c)
        {
            if(coleccionableReal == null)
            {
                return false;
            }
            else
            {
                return coleccionableReal.contiene(c);
            }
        }

        public int cuantos()
        {
            if (coleccionableReal == null)
            {
                return 0;
            }
            else
            {
                return coleccionableReal.cuantos();
            }
        }

        public Comparable maximo()
        {
            return max;
        }

        public Comparable minimo()
        {
            return min;
        }

        public void ordenar()
        {
            if (coleccionableReal != null)
            {
                coleccionableReal.ordenar();
            }
        }
    }
}
