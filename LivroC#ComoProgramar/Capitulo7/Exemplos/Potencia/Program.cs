using System;
using static System.Console;

namespace Potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // mostrar
            WriteLine($"Potência(10) = {Potencia(10)}");

            WriteLine($"Potência(2, 10) = {Potencia(2, 10)}");

            Console.WriteLine("Hello World!");
        } // fim main

        // cria o método Potencia
        static int Potencia( int valorBase, int expoente = 2 )
        {
            int resultado = 1;

            // loop para calcular a potência
            for( int i = 1; i <= expoente; i++ )
            {
                resultado *= valorBase;
            } // fim for

            return resultado;
        } // fim método Potencia
    } // fim classe
} // fim namespace
