using System;
using static System.Console;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa tela
            Clear();

            // cria variáveis
            var d1 = 10;
            var d2 = 20;
            var d3 = 30;
            var d4 = 40;
            
            // imprima
            WriteLine( $"d1 = {d1:f1}\nd2 = {d2:f1}\nd3 = {d3:f1}\nd4 = {d4:f1}");

            // imprima
            WriteLine( $"\nA média entre d1 e d2 é {Media(d1, d2):f1}" );
            WriteLine( $"A média entre d1, d2, d3 é {Media(d1, d2, d3):f1}" );
            WriteLine( $"A média entre d2 e d4 é {Media(d2, d4):f1}" );

        } // fim main

        // cria a função média
        static double Media( params double[] numeros )
        {
            // cria variável
            var total = 0.0;

            // loop para percorrer o vetor números
            // para cada número em números
            foreach( var numero in numeros )
            {
                // some o número
                total += numero;
            } // fim foreach

            // se o tamanho do vetor diferente de zero
            return numeros.Length != 0 ? total / numeros.Length:0.0;

        } // fim media

    } // fim classe
} // fim namespace
