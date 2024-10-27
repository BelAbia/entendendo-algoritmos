using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    public static class SomaItensDaLista
    {
        public static int CalculaNumerosDeItens(List<int> itens)
        {
            if(itens.Count == 0) return 0;

            itens.RemoveAt(0);
            return 1 + CalculaNumerosDeItens(itens);
        }
    }
}
