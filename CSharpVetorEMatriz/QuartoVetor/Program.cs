using System;
using static System.Console;

namespace QuartoVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria uma constante
            const int TAMANHO = 10;
            //  cria o vetor
            int[] vetor = new int[TAMANHO];
            int soma = 0;

            // limpa tela
            Clear();

            // loop para adicionar valores ao vetor
            for( int adicionar = 0; adicionar < TAMANHO; adicionar++ )
            {
                // adiciona valores ao vetor
                vetor[ adicionar ] = adicionar * 3;
                soma += vetor[ adicionar ];

            } // fim for adicionar

            WriteLine( $"Índice {"Valor", 5}" );

            // loop mostrar valores do vetor
            for( int mostrar = 0; mostrar < TAMANHO; mostrar++ )
            {
                // imprime
                WriteLine( $" {mostrar + 1, 3} {vetor[ mostrar ], 5}" );
            } // fim for mostrar

            // imprime
            Console.WriteLine( $"Soma = {soma}");
        } // fim main

    } // fim classe
} // fim namespace
