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

            // cabeçalho
            WriteLine("FATORIAL DE UM NÚMERO" );

            // loop para o fatorial
            for( var contar = 0; contar <= 10; contar++ )
            {
                WriteLine($"{contar}! = {Fatorial(contar)}" );
            } // fim for 

            Console.WriteLine("Hello World!");
        } // fim main

        // cria a função fatorial
        static long Fatorial( long numero )
        {
            if( numero == 1 || numero == 0 )
            {
                // retorne 1
                return 1;
            } // fim if

            // se não
            else
            {
                // retorneo numero multiplicado pelo próprio fatorial
                return numero * Fatorial( numero - 1 );
            } // fim else
        } // fim função

    }// fim classe
} // fim namespace
