using System;
using static System.Console;

namespace InicializandoVetor3
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpar a tela
            Clear();
            
            // cria constante
            const int VetorLength = 5;

            // cria vetor
            int[] vetor = new int[VetorLength];

            // loop para adicionar valores ao vetor
            for( int i = 0; i < VetorLength; i++ )
            {
                vetor[ i ] = 2 + 2 * i;
            } // fim for

            // cabeçalho
            WriteLine($"{"Índice"}{"Valor", 8}" );

            // loop para mostrar os valores do vetor
            for( int i = 0; i < VetorLength; i++ )
            {
                WriteLine($"{ i, 6}{vetor[ i ], 6}" );
            } // fim for

            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim namespace
