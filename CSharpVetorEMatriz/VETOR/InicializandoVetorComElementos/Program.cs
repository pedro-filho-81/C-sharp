using System;
using static System.Console;

namespace InicializandoVetorComElementos
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria e inicializa um vetor
            int[] vetor = { 36, 25, 45, 98, 10, 78 };

            // cabeçalho
            WriteLine($"{"Índice"}{"Valor", 8}" );

            // loop para mostra os elementos do vetor
            for( int i = 0; i < vetor.Length; i++ )
            {
                WriteLine($"{i , 3}{vetor[ i ], 10}" );
            } // fim for
            
        } // fim main
    } // fim classe
} // fim namespace
