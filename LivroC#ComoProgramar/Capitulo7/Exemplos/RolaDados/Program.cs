using System;
using static System.Console;

namespace RolaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria o objeto randômico
            Random numerosAleatorios = new Random();

            // loop para gerar 60000 números entre 1 e 6
            for( int i = 0; i < 60000; i++ )
            {
                // se i igual a multiplos de 20
                if( i % 20 == 0 )
                    // pula uma linha
                    WriteLine();

                // cria variável que recebe números aleatórios entre 1 e 6
                int face = numerosAleatorios.Next( 1, 7 );

                // mostra os números
                Write( $"{face} " );

            } // fim for

            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim namespace
