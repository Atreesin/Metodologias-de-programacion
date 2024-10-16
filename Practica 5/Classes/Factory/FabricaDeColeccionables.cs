using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5.Classes.Factory
{
    public abstract class FabricaDeColeccionables
    {
        public const int PILA = 1;
        public const int COLA = 2;
        public const int COLECCIONMULTIPLE = 3;
        public const int CONJUNTO = 4;
        public const int DICCIONARIO = 5;

        /// <summary>
        /// Crea un Coleccionable Elegido.
        /// </summary>
        /// <param name="opcion">
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
        /// <returns>
        /// El Coleccionable Elejido de tipo <see cref="Coleccionable"/> 
        /// </returns>
        public static Coleccionable crearColeccionable(int opcion)
        {
            FabricaDeColeccionables factory = null;
            switch (opcion)
            {
                case PILA:
                    factory = new FabricaDePila();
                    break;
                case COLA:
                    factory = new FabricaDeCola();
                    break;
                case COLECCIONMULTIPLE:
                    factory = new FabricaDeColeccionMultiple();
                    break;
                case CONJUNTO:
                    factory = new FabricaDeConjunto();
                    break;
                case DICCIONARIO:
                    factory = new FabricaDeDiccionario();
                    break;
            }
            return factory.crearColeccionable();
        }

        public abstract Coleccionable crearColeccionable();

    }


    /********************************************/
    public class FabricaDePila : FabricaDeColeccionables
    {
        public override Coleccionable crearColeccionable()
        {
            return new Pila();
        }
    }

    public class FabricaDeCola : FabricaDeColeccionables
    {
        public override Coleccionable crearColeccionable()
        {
            return new Cola();
        }
    }

    public class FabricaDeColeccionMultiple : FabricaDeColeccionables
    {
        public override Coleccionable crearColeccionable()
        {
            Pila pila = (Pila)FabricaDeColeccionables.crearColeccionable(1);
            Cola cola = (Cola)FabricaDeColeccionables.crearColeccionable(2);

            return new ColeccionMultiple(pila, cola);
        }
    }

    public class FabricaDeConjunto : FabricaDeColeccionables
    {
        public override Coleccionable crearColeccionable()
        {
            return new Conjunto();
        }
    }

    public class FabricaDeDiccionario : FabricaDeColeccionables
    {
        public override Coleccionable crearColeccionable()
        {
            return new Diccionario();
        }
    }


}
