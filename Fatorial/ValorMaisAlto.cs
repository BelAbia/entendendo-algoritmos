using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    public static class ValorMaisAlto
    {
        public static int ObtemValorMaisAlto(List<int> numeros)
        {
            if (numeros.Count == 2)
                return numeros[0] > numeros[1] 
                    ? numeros[0] : numeros[1];

            if (numeros[1] < numeros[0])
            {
                numeros.RemoveAt(1);
            }
            else
            {
                numeros.RemoveAt(0);
            }

            return ObtemValorMaisAlto(numeros);
        }
    }
}
