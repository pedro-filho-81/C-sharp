using System;
using static System.Console;

namespace SobrecargaDeConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria o objeto hora para a classe tempo2
            var horario1 = new Tempo2(12, 25, 30 );
            WriteLine($"{horario1.HorarioUniversal()}");
            WriteLine($"{horario1.HorarioParaString()}\n");

            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim namespace
