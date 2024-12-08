using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadoCalculadora05_12
{
    public class Calculos
    {
        public static float Sumar(int a, int b) 
        {
            return a + b;
        }
        public static float Restar(int a, int b)
        {
            return a - b;
        }
        public static float Multiplicar(int a, int b)
        {
            return a * b;
        }
        public static float Dividir(int a, int b)
        {
            return (float)a/b;
        }
    }
}
