﻿using Practica_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2.Classes
{
    public class PorDni : Estrategia
    {
        public bool sosIgual(Comparable alumno1, Comparable alumno2)
        {
            if ((((Alumno)alumno1).getDni()).sosIgual(((Alumno)alumno2).getDni()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMenor(Comparable alumno1, Comparable alumno2)
        {
            if ((((Alumno)alumno1).getDni()).sosMenor(((Alumno)alumno2).getDni()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMayor(Comparable alumno1, Comparable alumno2)
        {
            if ((((Alumno)alumno1).getDni()).sosMayor(((Alumno)alumno2).getDni()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "dni";
        }
    }
}
