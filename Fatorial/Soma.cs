using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    public static class Soma
    {
        public static int CalcularSoma(List<int> numeros)
        {
            if(numeros.Count == 0) return 0;

            var primeiroElemento = numeros[0];
            numeros.RemoveAt(0);
            return primeiroElemento + CalcularSoma(numeros);
        }
    }
}
