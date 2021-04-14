using System;

namespace Misterio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria variável
            int contador = 1;
            // conte até 10
            while( contador <= 10 )
            {
                // imprima asterisco se o valor for ímpar
                Console.WriteLine(contador % 2 == 1 ? "*****" : "++++++++++" );

                contador++; // soma 1 ao contador
            } // fim while

            Console.WriteLine("Hello World!");
            Console.ReadKey();
            Console.Clear();

        } // fim main
    } // fim classe
} // fim namespace
