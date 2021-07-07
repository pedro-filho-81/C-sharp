using System;
using static System.Console;

namespace InicializaMatriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria uma matriz retangulas e inicializa
            int[ , ] matrizRetangular = { {1, 2, 3}, { 7, 8, 9 }, {4, 5, 6} };

            int [][] matrizIrregular = { new int[]{1, 2}, 
                                        new int[]{3},
                                        new int[]{9, 8, 7, 6, 5 }, 
                                        new int[]{4, 5, 6} };

            // chama métodos
            MostrarMatriz(matrizRetangular);
            MostrarElementos(matrizIrregular);
            WriteLine();

        } // fim main

        // criar método mostrar matriz
        static void MostrarMatriz( int[,] matriz )
        {
            WriteLine("Mostra os valores da matriz retangular." );

            // loop para crair linha
            for( int linha = 0; linha < matriz.GetLength(0); linha++ )
            {
                // loop para criar coluna
                for(int coluna = 0; coluna < matriz.GetLength(1); coluna++ )
                {
                    // mostra os elementos da matriz
                   Write( $"{matriz[linha, coluna ]} " );
                } // fim for coluna

                WriteLine(); // pula linha

            } // fim for
        } // fim método

        // cria método mostrar elementos
        static void MostrarElementos( int[][] matriz)
        {
            WriteLine("Mostrar elementos da matriz.");
            
            foreach( var linha in matriz )
            {
                foreach( var elemento in linha )
                {
                    Write($"{elemento} " );
                } // fim foreach

                WriteLine(); // pula linha
            } // fim foreach

        } // fim método
    } // fim clase
} // fim name
