using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    public static class Fatorial
    {
        public static int CalcularFatorial(int numero)
        {
            if (numero == 1)
            {
                return 1;
            }
            else
            {
                return numero * CalcularFatorial(numero - 1);
            }
        }
    }
}
