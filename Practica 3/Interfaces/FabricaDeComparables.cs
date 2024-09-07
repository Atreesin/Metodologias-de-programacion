using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    public  interface FabricaDeComparables
    {
        Comparable crearAleatorio(int opcion);
        Comparable crearPorTeclado(int opcion);
    }
}
