using System;
using static System.Console;

namespace SomaValoresDoVetor4
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria uma constante
            const int TAMANHO = 10;

            // cria vetor
            int[] vetor = new int[ TAMANHO ];

            // cria o objeto randômico
            Random numerosAleatorios = new Random();

            // cria variável soma
            int soma = 0;

            // loop para adicionar os valores
            for( int i = 0; i < TAMANHO; i++ )
            {
               vetor[ i ] =  numerosAleatorios.Next( 50 );
            } // fim for adicionar

            WriteLine($"{"Índice"}{"Valor", 8}" );

            // loop para mostrar os valores do vetor
            for( int i = 0; i < TAMANHO; i++ )
            {
                WriteLine($"{ i, 6}{vetor[ i ], 5}");

                soma += vetor[ i ];
            } // fim for mostrar

            Console.WriteLine($"Soma = {soma}");
        } // fim main
    } // fim classe
} // fim namespace
