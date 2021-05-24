using System;
using static System.Console;

namespace ArgumentoLinhaDeComando
{
    class Program
    {
        // usando argumentos de linha de comando para inicializar um array

        static void Main(string[] args)
        {
            Clear(); // limpa a tela

            // se o tamanho do argumento diferente de 3
            if( args.Length != 3 )
            {
                WriteLine( "ERRO! - Favor reentrar com o comando incluindo\n" +
                            "o tamanho do array, inicialize o valor e o incremento." );
            } // fim if
            // se não
            else
            {
                // obtenha o tamanho do array
                var tamanhoDoArray = int.Parse(args[0]);
                var vetor = new int[ tamanhoDoArray ]; // cria o vetor

                var valorInicial = int.Parse(args[1]);
                var incremento = int.Parse(args[2]);

                // calcula o valor de cada elemento do vetor
                for( int contador = 0; contador < vetor.Length; contador++ )
                {
                    vetor[ contador ] = valorInicial + incremento * contador;
                } // fim for

                // imprima
                WriteLine( $"Índice {"Valor", 8}" );

                // mostra elemsntos do array
                for( int contador = 0; contador < vetor.Length; contador++ )
                {
                    WriteLine( $"{contador, 5}{vetor[ contador ], 8}" );
                } // fim for
            } // fim else

            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim namespace
