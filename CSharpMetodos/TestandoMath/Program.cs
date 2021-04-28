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

            WriteLine("Abs - Retorna o valor absoluto do número.");
            WriteLine($"Math.Abs(23.7) = {Math.Abs(23.7)}");
            WriteLine($"Math.Abs(-23.7) = {Math.Abs(-23.7)}");
            WriteLine($"Math.Abs(0.0) = {Math.Abs(0.0)}");

            WriteLine("\nCeiling - retorna um valor menor, maior ou igual ao número especificado.");
            WriteLine($"Math.Ceiling(9.2) = {Math.Ceiling(9.2)}");
            WriteLine($"Math.Ceiling(-9.8) = {Math.Ceiling(-9.8)}");

            WriteLine($"\nCos - retorna o coseno do número.");
            WriteLine($"Math.Cos(0.0) = {Math.Cos(0.0)}");

            WriteLine($"\nExp - retorna o expoente.");
            WriteLine($"Math.Exp(1.0) = {Math.Exp(1.0)}");
            WriteLine($"Math.Exp(2.0) = {Math.Exp(2.0)}");

            WriteLine($"\nFloor - arredonda um número para mais ou para menos.");
            WriteLine($"Math.Floor(9.2) = {Math.Floor(9.2)}");
            WriteLine($"Math.Floor(-9.8) = {Math.Floor(-9.8)}");
            
            WriteLine($"\nMath.Log(Math.E) = {Math.Log(Math.E)}");
            WriteLine($"Math.Log(Math.E * Math.E) = {Math.Log(Math.E * Math.E)}");
            
            WriteLine($"\nMath.Max(2.3, 12.7) = {Math.Max(2.3, 12.7)}");
            WriteLine($"Math.Max(-2.3, -12.7) = {Math.Max(-2.3, -12.7)}");
            
            WriteLine($"\nMath.Min(2.3, 12.7) = {Math.Min(2.3, 12.7)}");
            WriteLine($"Math.Max(-2.3, -12.7) = {Math.Min(-2.3, -12.7)}");

            WriteLine($"\nMath.Pow(2.0, 7.0) = {Math.Pow(2.0, 7.0)}");
            WriteLine($"Math.Pow(9.0, 0.5) = {Math.Pow(9.0, 0.5)}");

            WriteLine($"\nMath.Sin(0.0) = {Math.Sin(0.0)}");

            WriteLine($"\nMath.Sqrt(900.0) = {Math.Sqrt(900.0)}");

            WriteLine($"\nMath.Tan(0.0) = {Math.Tan(0.0)}");
            
            Console.WriteLine("Hello World!");
        }
    }
}
