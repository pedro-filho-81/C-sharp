using System;

namespace SobrecargaDeMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            // o compilador escolhe o tipo do método para resolver o problema
            Console.WriteLine($"O quadrado do inteiro 7 é {Quadrado(7)}");
            Console.WriteLine($"O quadrado do double 7,5 é {Quadrado(7.5)}");
            Console.WriteLine($"O QUADRADO DO DOUBLE 9,87 É {Quadrado(9.87)}");

            Console.ReadKey();
            Console.Clear();
        } // fim main

        // cria o método Quadrado do tipo double
        public static double Quadrado( double numeroDouble )
        {
            System.Console.WriteLine($"Chamada com o número double: {numeroDouble}");
            return numeroDouble * numeroDouble;
        } // fim quadrado

        // cria o método Quadrado do tipo inteiro
        public static int Quadrado( int numeroInteiro )
        {
            System.Console.WriteLine($"Chamada com o número inteiro: {numeroInteiro}");

            return numeroInteiro * numeroInteiro;

        } // fim Quadrado 

    } // fim classe
} // fim namespace
