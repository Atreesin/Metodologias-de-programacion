using Practica_7.Classes.Chain_of_Responsability;
using System;
using System.Collections.Generic;

namespace Practica_7.Classes
{
    

    public abstract class FabricaDeComparables
    {
        public const int NUMERO = 1;
        public const int NUMERODNI = 2;
        public const int NUMEROLEGAJO = 3;
        public const int NUMEROPROMEDIO = 4;
        public const int CLAVEVALOR = 5;
        public const int PROFESOR = 6;

        protected Manejador manejador;

        
        protected FabricaDeComparables()
        {
            manejador = crearCadenaDeResponsabilidades();
        }

        public static int FabricaPorDefecto =NUMERO;

        /// <summary>
        /// Crea un Numero de tipo <see cref="Comparable"/> Aleatorio.
        /// </summary>
        /// <returns>
        /// Un Numero de tipo <see cref="Comparable"/>.
        /// </returns>
        public static Comparable CrearComparableAleatorioPreseteado()
        {
            return CrearAleatorio(FabricaPorDefecto);
        }
        /// <summary>
        /// Crea un Numero de tipo <see cref="Comparable"/> pidiendo que ingrese el valor por teclado.
        /// </summary>
        /// /// <returns>
        /// Un Numero de tipo <see cref="Comparable"/>.
        /// </returns>
        public static Comparable CrearComparablePorTecladoPreseteado()
        {
            return CrearPorTeclado(FabricaPorDefecto);
        }


        /// <summary>
        /// Crea un Comparable Aleatorio.
        /// 
        /// 
        /// <list type="table">
        /// <b>Opciones:</b>
        /// <item>
        /// <description>1 - Numero</description>
        /// </item>
        /// <item>
        /// <description>2 - Numero de DNI</description>
        /// </item>
        /// <item>
        /// <description>3 - Numero de Legajo</description>
        /// </item>
        /// <item>
        /// <description>4 - Numero de Promedio</description>
        /// </item>
        /// <item>
        /// <description>5 - ClaveValor</description>
        /// </item>
        /// <item>
        /// <description>6 - Profesor</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <returns>
        /// El elemento elegido de tipo <see cref="Comparable"/>
        /// </returns>
        public static Comparable CrearAleatorio(int opcion)
        {
            
            FabricaDeComparables fabrica = null;
            
            switch (opcion)
            {
                case NUMERO:
                    fabrica = new FabricaDeNumeroAleatorio();
                    break;
                case NUMERODNI:
                    fabrica = new FabricaDeNumeroDniAleatorio();
                    break;
                case NUMEROPROMEDIO:
                    fabrica = new FabricaDeNumeroDniAleatorio();
                    break;
                case NUMEROLEGAJO:
                    fabrica = new FabricaDeNumeroDniAleatorio();
                    break;
                case CLAVEVALOR:
                    fabrica = new FabricaDeClaveValorAleatorio();
                    break;
                case PROFESOR:
                    fabrica = new FabricaDeProfesorAleatorio();
                    break;
            }

            return fabrica.CrearComparable();
        }


        /// <summary>
        /// Crea un Comparable desde Archivo.
        /// 
        /// 
        /// <list type="table">
        /// <b>Opciones:</b>
        /// <item>
        /// <description>1 - Numero</description>
        /// </item>
        /// <item>
        /// <description>2 - Numero de DNI</description>
        /// </item>
        /// <item>
        /// <description>3 - Numero de Legajo</description>
        /// </item>
        /// <item>
        /// <description>4 - Numero de Promedio</description>
        /// </item>
        /// <item>
        /// <description>5 - ClaveValor</description>
        /// </item>
        /// <item>
        /// <description>6 - Profesor</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <returns>
        /// El elemento elegido de tipo <see cref="Comparable"/>
        /// </returns>
        public static Comparable CrearDesdeArchivo(int opcion)
        {

            FabricaDeComparables fabrica = null;

            switch (opcion)
            {
                case NUMERO:
                    fabrica = new FabricaDeNumeroDesdeArchivo();
                    break;
                case NUMERODNI:
                    fabrica = new FabricaDeNumeroDniDesdeArchivo();
                    break;
                case NUMEROPROMEDIO:
                    fabrica = new FabricaDeNumeroDniDesdeArchivo();
                    break;
                case NUMEROLEGAJO:
                    fabrica = new FabricaDeNumeroDniDesdeArchivo();
                    break;
                case CLAVEVALOR:
                    fabrica = new FabricaDeClaveValorDesdeArchivo();
                    break;
                case PROFESOR:
                    fabrica = new FabricaDeProfesorDesdeArchivo();
                    break;
            }

            return fabrica.CrearComparable();
        }


        /// <summary>
        /// Crea un Comparable al que se le tiene que ingresar los valores por teclado.
        /// 
        /// <list type="table">
        /// <b>Opciones:</b>
        /// <item>
        /// <description>1 - Numero</description>
        /// </item>
        /// <item>
        /// <description>2 - Numero de DNI</description>
        /// </item>
        /// <item>
        /// <description>3 - Numero de Legajo</description>
        /// </item>
        /// <item>
        /// <description>4 - Numero de Promedio</description>
        /// </item>
        /// <item>
        /// <description>5 - ClaveValor</description>
        /// </item>
        /// <item>
        /// <description>6 - Profesor</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <returns>
        /// El elemento elegido de tipo <see cref="Comparable"/>
        /// </returns>
        public static Comparable CrearPorTeclado(int opcion)
        {
            FabricaDeComparables fabrica = null;
            
            switch (opcion)
            {
                case NUMERO:
                    fabrica = new FabricaDeNumeroPorTeclado();
                    break;
                case NUMERODNI:
                    fabrica = new FabricaDeNumeroPorTeclado();
                    break;
                case NUMEROPROMEDIO:
                    fabrica = new FabricaDeNumeroPorTeclado();
                    break;
                case NUMEROLEGAJO:
                    fabrica = new FabricaDeNumeroPorTeclado();
                    break;
                case CLAVEVALOR:
                    fabrica = new FabricaDeClaveValorPorTeclado();
                    break;
                case PROFESOR:
                    fabrica = new FabricaDeProfesorPorTeclado();
                    break;
            }

            return fabrica.CrearComparable();
        }

        private Manejador crearCadenaDeResponsabilidades()
        {
            Manejador m = LectorDeArchivos.getInstance(null);
            m = new LectorDeDatos(m);
            m = GeneradorDeDatosAleatorios.getInstance(m);
            return m;
        }

        public abstract Comparable CrearComparable();
    }


    /* ALEATORIOS */
    /**************************************************************************/
    
    public class FabricaDeProfesorAleatorio : FabricaDeComparables
    {
        
        public override Comparable CrearComparable()
        {
            // generando nombres aleatorios utilizando el generador de datos aleatorios
            string nombre = $"{manejador.stringAleatorio(manejador.numeroAleatorio(10))} {manejador.stringAleatorio(manejador.numeroAleatorio(10))}";
            Numero dni = (Numero)(new FabricaDeNumeroDniAleatorio().CrearComparable());
            Numero antiguedad = (Numero)(new FabricaDeNumeroLegajoAleatorio().CrearComparable());
            

            Profesor profesor = new Profesor(nombre, dni, antiguedad);
            profesor.setCriterio(new PorAntiguedad());
            return profesor;
        }
    }


    public class FabricaDeNumeroAleatorio : FabricaDeComparables
    {
        
        public override Comparable CrearComparable()
        {
            return new Numero(manejador.numeroAleatorio(100));
        }
    }

    public class FabricaDeNumeroDniAleatorio : FabricaDeComparables
    {
        
        public override Comparable CrearComparable()
        {
            return new Numero(manejador.numeroAleatorio(99999999));
        }
    }

    public class FabricaDeNumeroLegajoAleatorio : FabricaDeComparables
    {
        
        public override Comparable CrearComparable()
        {
            return new Numero(manejador.numeroAleatorio(999999));
        }
    }

    public class FabricaDeNumeroPromedioAleatorio : FabricaDeComparables
    {
        
        public override Comparable CrearComparable()
        {
            return new Numero(manejador.numeroAleatorio(10));
        }
    }

    public class FabricaDeClaveValorAleatorio : FabricaDeComparables
    {
        
        public override Comparable CrearComparable()
        {
            Comparable clave = FabricaDeComparables.CrearAleatorio(1);
            Comparable alumno = FabricaDeComparables.CrearAleatorio(5);
            return new ClaveValor(clave, alumno);
        }
        
    }

    /* DESDE ARCHIVO */
    /**************************************************************************/

    public class FabricaDeProfesorDesdeArchivo : FabricaDeComparables
    {
        public override Comparable CrearComparable()
        {
            // generando nombres aleatorios utilizando el generador de datos aleatorios
            string nombre = $"{manejador.stringDesdeArchivo(manejador.numeroAleatorio(12))} {manejador.stringDesdeArchivo(manejador.numeroAleatorio(12))}";
            Numero dni = (Numero)(new FabricaDeNumeroDniDesdeArchivo().CrearComparable());
            Numero antiguedad = (Numero)(new FabricaDeNumeroLegajoDesdeArchivo().CrearComparable());


            Profesor profesor = new Profesor(nombre, dni, antiguedad);
            profesor.setCriterio(new PorAntiguedad());
            return profesor;
        }
    }

    public class FabricaDeNumeroDesdeArchivo : FabricaDeComparables
    {
        public override Comparable CrearComparable()
        {
            return new Numero((int)manejador.numeroDesdeArchivo(1));
        }
    }

    public class FabricaDeNumeroDniDesdeArchivo : FabricaDeComparables
    {
        public override Comparable CrearComparable()
        {
            return new Numero((int)manejador.numeroDesdeArchivo(1));
        }
    }

    public class FabricaDeNumeroLegajoDesdeArchivo : FabricaDeComparables
    {
        public override Comparable CrearComparable()
        {
            return new Numero((int)manejador.numeroDesdeArchivo(1));
        }
    }

    public class FabricaDeNumeroPromedioDesdeArchivo : FabricaDeComparables
    {
        public override Comparable CrearComparable()
        {
            return new Numero((int)manejador.numeroDesdeArchivo(3)%10);
        }
    }

    public class FabricaDeClaveValorDesdeArchivo : FabricaDeComparables
    {
        public override Comparable CrearComparable()
        {
            Comparable clave = FabricaDeComparables.CrearDesdeArchivo(1);
            Comparable alumno = FabricaDeComparables.CrearDesdeArchivo(5);
            return new ClaveValor(clave, alumno);
        }

    }

    /* POR TECLADO */
    /***************************************************************/


    public class FabricaDeProfesorPorTeclado : FabricaDeComparables
    {
        public override Comparable CrearComparable()
        {
            Console.WriteLine("Nombre y apellido:");
            string nombre = manejador.stringPorTeclado();
            Console.WriteLine("Dni:");
            Numero dni = (Numero)new FabricaDeNumeroPorTeclado().CrearComparable();
            Console.WriteLine("Antiguedad:");
            Numero antiguedad = (Numero)new FabricaDeNumeroPorTeclado().CrearComparable();
            
            Profesor profesor = new Profesor(nombre, dni, antiguedad);
            profesor.setCriterio(new PorAntiguedad());
            return profesor;
        }
    }


    public class FabricaDeNumeroPorTeclado : FabricaDeComparables
    {
        public override Comparable CrearComparable()
        {
            return new Numero(manejador.numeroPorTeclado());
        }
    }

    
    public class FabricaDeClaveValorPorTeclado : FabricaDeComparables
    {
        public override Comparable CrearComparable()
        {
            Console.WriteLine("ingrese clave:");
            Comparable clave = FabricaDeComparables.CrearPorTeclado(1);
            Console.WriteLine("ingresar datos de Alumno:");
            Comparable alumno = FabricaDeComparables.CrearPorTeclado(5);
            return new ClaveValor(clave, alumno);
        }
    }
}
