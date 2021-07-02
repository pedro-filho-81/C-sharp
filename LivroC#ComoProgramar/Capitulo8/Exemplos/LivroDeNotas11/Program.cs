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
            int[] vetorNotas = {87, 97, 75, 65, 58, 47, 35, 26, 10, 7 };

            // cria o objeto da classe
            LivroDeNotas minhaNota = new LivroDeNotas("C# Como Programar", vetorNotas );

            minhaNota.MostrarMensagem();
            minhaNota.ProcessarNotas();

            Console.WriteLine("Hello World!");
        }
    }
}
