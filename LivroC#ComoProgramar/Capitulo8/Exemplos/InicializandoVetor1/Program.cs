using System;
using static System.Console;

namespace InicializandoVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria um vetor
            int[] vetor = new int[10];

            // cria cabeçalho
            WriteLine($"{"Índice"}{"Valor", 8}");

            // loop para mostra indice e valor
            for( int contar = 0; contar < vetor.Length; contar++ )
            {
                WriteLine($"{contar, 6}{vetor[ contar ], 6}");
            } // fim for
            
            Console.WriteLine("Hello World!");
        } // fim main

        // método índice
        static void Indice( int indice )
        {

        }
    } // fim classe
} // fim namespace
