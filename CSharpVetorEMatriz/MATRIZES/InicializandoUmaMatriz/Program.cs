using System;
using static System.Console;

namespace InicializandoUmaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria uma matriz retangular
            int[ , ] retangular = { {1, 2, 3 }, { 4, 5, 6 } };

            // cria  uma outra matrizes
            int[][] outraMatriz = { new int[]{1, 2}, // primeira linha
                       new int[]{3}, // segunda linha
                       new int[]{3, 4, 5 } }; // terceira linha
            
            // chama o método Mostrar matriz retangular e
            // usa a matriz retangular como atributo
            MostrarMatrizRetangular( retangular );
            
            WriteLine(); // pula linha
            
            // chama o método mostrar outra matriz
            MostrarOutraMatriz( outraMatriz );

        } // fim main

        // cria o metodo mostrar matriz retangular
        static void MostrarMatrizRetangular( int[ , ] matriz )
        {
            WriteLine("Mostra os valores da matriz retangular." );

            // loop para criar uma linha
            for( int linha = 0; linha < matriz.GetLength( 0 ); linha++ )
            {
                for( int coluna = 0; coluna < matriz.GetLength( 1 ); coluna++ )
                {
                    Write($"{matriz[ linha, coluna ]} ");
                } // fim for coluna
                
                // pula linha
                WriteLine();
            } // fim for linha

        } // fim função

        // cria o método mostrar outra matriz
        static void MostrarOutraMatriz( int[][] matriz )
        {
            // imprima
            WriteLine("Mostra os valores da outra matriz." );

            // loop para criar linhas
            foreach( var linha in matriz )
            {
                // loop para percorrer os elemantos na linha
                foreach( var elementos in linha )
                {
                    // mostra os elementos da linha
                    Write( $"{elementos} " );
                } // fim foreach elementos

                WriteLine(); // pula linha
            } // fim foreach elementos
        } // fim método

    } // fim classe
} // fim namespace
