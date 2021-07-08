using System;
using static System.Console;

namespace Parametros
{
    class Program
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

        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria variáveis
            var d1 = 10.0;
            var d2 = 30.0;
            var d3 = 40.0;
            var d4 = 50.0;

            // mostra as variáveis e seus valores
            WriteLine($"d1 = {d1:f1}\nd2 = {d2:f1}\nd3 = {d3:f1}\nd4 = {d4:f1}");


            // mostra a média entre os valores
            WriteLine($"A média entre d1 e d2 é {Media(d1, d2):f2}");

            WriteLine($"A média entre d1, d2, d3 é {Media(d1, d2, d3):f2}" );

            WriteLine($"A média entre d1, d2, d3 e d4 é {Media(d1, d2, d3, d4):f2}" );

            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe principal
} // fim name
