using System;
using static System.Console;

namespace Incremento
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cabeçalho
            WriteLine("INCREMENTO / DECREMENTO");

            // cria variável
            int c = 5;

            // mostrar resultado
            WriteLine($"int c = {c}");
            WriteLine($"Pré-incremento ++c = {++c}");
            WriteLine($"Variável c após o Pré-incremento = {c}");
            
            // mostrar resultado
            int d = 5;
            WriteLine($"\nint d = {d}");
            WriteLine($"Pós-incremento d++ = {d++}");
            WriteLine($"Variável d após o Pós-incremento = {d}");

            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim namespace
