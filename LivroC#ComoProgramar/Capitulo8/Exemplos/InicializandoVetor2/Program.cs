using System;
using static System.Console;

namespace InicializandoVetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria vetor
            int[] vetor = {15, 25, 85, 95, 75, 35, 45 };

            WriteLine($"{"Índice"}{"Valor", 8}" );

            // loop para mostrar valores
            for( int contar = 0; contar < vetor.Length; contar++ )
            {
                WriteLine( $"{contar, 5}{vetor[ contar ], 8}" );
            } // fim for

            Console.WriteLine("Hello World!");
        }
    }
}
