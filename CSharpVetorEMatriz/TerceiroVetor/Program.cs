﻿using System;
using static System.Console;

namespace TerceiroVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTE INTEIRA
            const int TAMANHO = 10;
            // cria variável para um vetor
            int[] vetor = new int[TAMANHO];

            // loop para adicionar valores ao vetor
            for( int adicionar = 0; adicionar < TAMANHO; adicionar++ )
            {
                vetor[ adicionar ] = 2 + 2 * adicionar;
            } // fim loop adicionar

            WriteLine($"Índice{"Valor", 8}" );

            for(int mostrar = 0; mostrar < TAMANHO; mostrar++ )
            {
                WriteLine( $"   {mostrar + 1, 3} {vetor[mostrar], 5}" );
            } // fim loop mostrar

            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim namespace
