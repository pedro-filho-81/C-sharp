using System;

namespace Histograma
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria e inicializa um vetor
            int[] numeros = { 10, 19, 25, 5, 7, 35, 30, 12, 3, 1 };

            // limpar a tela
            Console.Clear();

            Console.WriteLine($"Índice {"Valor",8} {"Histograma", 12}" );

            // loop para mostra o resultado
            for( int mostrar = 0; mostrar < numeros.Length; mostrar++ )
            {
                // imprime resultado
                Console.Write( $"{mostrar + 1, 3}{numeros[mostrar], 10} {" ", 5}" );

                // loop para o histograma
                for( int i = 0; i < numeros[mostrar]; i++ )
                {
                    // imprime asterisco
                    Console.Write( "*" );
                } // fim for

                // pula linha
                Console.WriteLine();

            } // fim for externo

            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim namespace
