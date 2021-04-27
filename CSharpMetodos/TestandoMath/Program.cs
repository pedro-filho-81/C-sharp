using System;
using static System.Console;

namespace TestandoMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear(); // limpa a tela

            // cabeçalho
            BackgroundColor = ConsoleColor.DarkBlue;
            ForegroundColor = ConsoleColor.White;
            WriteLine("MÉTODO MATH");
            ResetColor();

            WriteLine($"Math.Abs(23.7) = {Math.Abs(23.7)}");
            WriteLine($"Math.Abs(-23.7) = {Math.Abs(-23.7)}");
            WriteLine($"Math.Abs(0.0) = {Math.Abs(0.0)}");

            WriteLine($"Math.Ceiling(9.2) = {Math.Ceiling(9.2)}");
            WriteLine($"Math.Ceiling(-9.8) = {Math.Ceiling(-9.8)}");

            WriteLine($"Math.Cos(0.0) = {Math.Cos(0.0)}");

            WriteLine($"Math.Exp(1.0) = {Math.Exp(1.0)}");
            WriteLine($"Math.Exp(2.0) = {Math.Exp(2.0)}");

            WriteLine($"Math.Floor(9.2) = {Math.Floor(9.2)}");
            WriteLine($"Math.Floor(-9.8) = {Math.Floor(-9.8)}");

            
            Console.WriteLine("Hello World!");
        }
    }
}
