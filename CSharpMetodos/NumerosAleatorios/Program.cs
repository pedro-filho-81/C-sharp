using System;

namespace NumerosAleatorios
{
    class Program
    {
        static void Main(string[] args)
        {    
            // cria o objeto para números aleatórios
            Random numero = new Random();

            // limpa a tela
            Console.Clear();

            // loop para imprimir 20 números aleatórios
            for( int i = 1; i <= 20; i++ )
            {
                // cria variável que recebe números entre 1 e 6 aleatórios
                int numeroAleatorio = numero.Next( 1, 7 );

                // imprime os números
                Console.Write($"{numeroAleatorio} " );

                // quando i multiplo de 5
                if( i % 5 == 0 )
                    // pule uma linha
                    System.Console.WriteLine();
            } // fim for
            
        } // fim main
    } // fim classe
} // fim namespace
