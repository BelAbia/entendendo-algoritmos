
int Fatorial(int numero)
{
    if(numero == 1)
    {
        return 1;
    }
    else
    {
        return numero * Fatorial(numero - 1);
    }
}

Console.WriteLine(Fatorial(2));
