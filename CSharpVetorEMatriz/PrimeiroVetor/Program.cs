using System;

namespace PrimeiroVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria variável para vetor
            int[] vetor = new int[10];

            // limpa a tela
            Console.Clear();

            // imprime 
            Console.WriteLine($"  Índice {"Valor",10}");

            // loop for para adicionar valores ao vetor
            for (int contar = 0; contar < vetor.Length; contar++)
            {
                // imprima o índice e o valor (0) adicionado a cada índice
                Console.WriteLine($"vetor[{contar}] {vetor[contar],10}");
            } // fim for

        } // fim main

        private static void NewMethod()
        {
            Console.Clear();
        }
    } // fim classe
} // fim namespace
