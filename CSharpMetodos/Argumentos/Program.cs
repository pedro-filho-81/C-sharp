using System;
using static System.Console;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            
            Console.WriteLine($"Existe {args.Length} argumentos");

            foreach(string arg in args )
            {
                WriteLine(arg);
            }
        }
    }
}
