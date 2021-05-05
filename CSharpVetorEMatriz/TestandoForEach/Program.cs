using System;
using static System.Console;

namespace TestandoForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear(); // limpa a tela

            // cria variável
            int[] array = {10, 53, 68, 69, 74, 58, 100, 23, 159, 78, 20 };
            int soma = 0;

            // loop para mostrar os valores
            foreach( int numero in array )
            {
                WriteLine($"{numero}");
                soma += numero;
            }

            Console.WriteLine($"Soma = {soma} Hello World!");
        }
    }
}
