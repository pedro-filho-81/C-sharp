using System;
using static System.Console;

namespace EncontraMaiorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cabeçalho
            WriteLine("ENCONTRAR O MAIOR VALOR" );

            // entrada de dados
            Write("Entre com o primeiro número: ");
            double numero1 = double.Parse(ReadLine());

            Write("Entre com o segundo número: ");
            double numero2 = double.Parse(ReadLine());

            Write("Entre com o terceiro número: ");
            double numero3 = double.Parse(ReadLine());

            double resultado = MaiorValor(numero1, numero2, numero3);

            Console.WriteLine($"O maior valor é {resultado}"); 
        } // fim main

        // cria método Maior valor
        public static double MaiorValor ( double numero1, double numero2, double numero3 )
        {
            // cria variáveis
            double maiorValor = numero1;

            if( maiorValor < numero2 )
            {
                maiorValor = numero2;
            } // fim if
            if ( maiorValor < numero3 )
            {
                maiorValor = numero3;
            } // fim else if

            // retorne o maior valor
            return maiorValor;
            
        } // fim maior valor

    } // fim classe
} // fim namespace
