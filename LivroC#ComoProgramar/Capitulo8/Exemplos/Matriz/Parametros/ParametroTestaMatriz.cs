using System;
using static System.Console;

class ParametroTestaMatriz
{
    static double Media(params double[] numeros )
    {
        var total = 0.0;

        foreach( var d in numeros )
        {
            total += d;
        } // fim loop

        return numeros.Length != 0 ? total / numeros.Length : 0.0;
    } // fim método média
} // fim classe
