using System;
using static System.Console;

namespace LivroDeNotas11
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();
            
            // cria o vetor notas
            int[] vetorNotas = {87, 68, 94, 100, 83, 78, 85, 91, 76, 87};

            // cria o objeto da classe
            LivroDeNotas minhaNota = new LivroDeNotas("C# Como Programar", vetorNotas );

            minhaNota.MostrarMensagem();
            minhaNota.ProcessarNotas();

            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim namespace
