using System;
using static System.Console;

namespace SaidaPorValorOuReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria variáveis
            int y = 5; // inicializa y com 5
            int z; // não inicializa z

            // mostra o valor de y
            WriteLine($"O valor de y é {y}" );
            WriteLine("O valor de z não é inicializado." );

            // passando y e z por referência
            QuadradoPorRef( ref y );
            QuadradoPorOut( out z );

            // mostra o valor de y e z depois da passagem por referência
            WriteLine($"O valor de y depois da passagem por referência é {y}" );
            WriteLine($"O valor de z depois da passagem por referência é {z}\n" );

            // passando y e z por valor
            Quadrado( y );
            Quadrado( z );

            // mostra o valor de y e z depois da passagem por valor
            WriteLine($"O valor de y depois da passagem por valor é {y}" );
            WriteLine($"O valor de z depois da passagem por valor é {z}\n" );

            Console.WriteLine("Hello World!");
        } // fim main

        // método quadrado por referência
        static void QuadradoPorRef( ref int x )
        {
            x *= x;
        } // fim método quadrado por referência

        // cria metodo quadrado por out
        static void QuadradoPorOut( out int x )
        {
            x = 6;
            x *= x;
        } // fim método

        // cria método quadrado por valor
        static void Quadrado( int x )
        {
            x *= x;
        } // fim método quadrado

    } // fim classe
} // fim namespace
