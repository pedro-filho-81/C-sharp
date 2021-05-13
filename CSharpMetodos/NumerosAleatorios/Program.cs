using System;

namespace NumerosAleatorios
{
    class Program
    {
        static void Main(string[] args)
        {    
            // 1º) cria o objeto para números aleatórios
            Random numero = new Random();

            // limpa a tela
            Console.Clear();

            // cabeçalho
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("GERAR 20 NÚMEROS ALEATÓRIOS");
            Console.ResetColor();

            // loop para imprimir 20 números aleatórios
            for( int i = 1; i <= 20; i++ )
            {
                // 2º) cria variável que recebe números aleatórios entre 1 e 6
                // 3º) use o objeto.Next(número); ou objeto.Next( valor inicial, 
                                                // valor final maior que o desejado );
                int numeroAleatorio = numero.Next( 1, 7 );

                // imprime os números
                Console.Write($" {numeroAleatorio} " );

                // quando i multiplo de 5
                if( i % 5 == 0 )
                    // pule uma linha
                    System.Console.WriteLine();

            } // fim for
            
        } // fim main
    } // fim classe
} // fim namespace
