﻿

namespace Practica_7.Interfaces
{
    public interface Estrategia
    {
        bool sosIgual(Comparable a, Comparable b);
        bool sosMenor(Comparable a, Comparable b);
        bool sosMayor(Comparable a, Comparable b);
    }
}
