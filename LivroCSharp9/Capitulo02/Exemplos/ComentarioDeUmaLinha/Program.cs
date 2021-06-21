using System;
using static System.Console;

namespace ComentarioDeUmaLinha
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // imprime na tela olá mundo
            Console.WriteLine("Hello World!");

            WriteLine($"A temperatura em {0:D} é {1}ºC", DateTime.Today, 16.18);
        }
    }
}
