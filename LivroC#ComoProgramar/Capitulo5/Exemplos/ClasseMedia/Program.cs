using System;
using static System.Console;

namespace ClasseMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria variáveis
            int total = 0;
            int contaNotas = 1;

            // enquanto conta notas menor que 10 faça
            while( contaNotas <= 10 )
            {
                Write("Entre com a nota: " );
                int nota = int.Parse(ReadLine());

                // somar notas
                total += nota;

                contaNotas = contaNotas + 1;
            } //  fim while

            // calcula a média
            int media = total / 10;

            // mostra o total e a média das notas
            WriteLine($"\nTotal das 10 notas {total}");
            WriteLine($"Média {media}");
            
            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim namespace
