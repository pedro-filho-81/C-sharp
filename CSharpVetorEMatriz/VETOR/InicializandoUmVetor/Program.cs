using System;
using static System.Console;

namespace InicializandoUmVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria um vetor com 5 espaços na memoria
            int[] vetor = new int[5]; // vetor para 5 elementos

            // cabeçalho
            WriteLine($"{"Índice"}{"Valor", 8}" );

            // mostrando os valores do vetor
            // loop para mostrar os elementos do vetor
            for( int contar = 0; contar < vetor.Length; contar++ )
            {
                // imprime a posição dos elementos e o valor
                WriteLine($"{contar, 3}  {vetor[contar], 5}" );
            } // fim for

        } // fim main
    } // fim classe
} // fim name space
