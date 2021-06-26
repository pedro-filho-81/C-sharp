using System;
using static System.Console;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela 
            Clear();

            // loop para calcular o fatorial
            for( long contar = 0; contar <= 10; contar++)
            {
                WriteLine($"{contar}! = {Fatorial(contar)}" );                
            } // fim for

            Console.WriteLine("Hello World!");
        } // fim main

        // método fatorial
        static long Fatorial( long numero )
        {
            if( numero == 1 || numero == 0 )
            {
                return 1;
            } // fim if
            else
            {
                return numero * Fatorial( numero - 1 );
            } // fim else
        } // fim método fatorial
    } // fim classe
} // fim namespace
