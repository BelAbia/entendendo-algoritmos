


var listaOrdenada = new List<int>()
{
    1, 2, 3, 4, 5, 6, 7, 8
};

var itemEscolhido = listaOrdenada[2];

var baixo = 0;
var alto =  listaOrdenada.Count - 1;

while (baixo <= alto)
{
    var meio = (baixo + alto) / 2;

    if(meio == itemEscolhido)
    {
        Console.WriteLine($"O item escolhido é {meio}");
        break;
    }else 
    if(meio > itemEscolhido)
    {
       alto = meio - 1;
    }
    else
    {
        baixo = meio + 1;
    }

}

