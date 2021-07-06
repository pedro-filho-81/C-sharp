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
            int[ , ] matrizRetangular = { {1, 2, 3}, {4, 5, 6} };

            int [][] matrizIrregular = { new int[]{1, 2}, new int[]{3}, new int[]{4, 5, 6} };

            // loop para crair linha
            for( int linha = 0; linha < matrizRetangular.GetLength(0); linha++ )
            {
                // loop para criar coluna
                for(int coluna = 0; coluna < matrizRetangular.GetLength(1); coluna++ )
                {
                    // mostra os elementos da matriz
                   Write( $"{matrizRetangular[linha, coluna ]} " );
                } // fim for coluna

                WriteLine(); // pula linha

            } // fim for

            WriteLine();

            foreach( var linha in matrizIrregular )
            {
                foreach( var elemento in linha )
                {
                    Write($"{elemento} " );
                } // fim foreach

                WriteLine(); // pula linha
            } // fim foreach

        } // fim main
    } // fim clase
} // fim name
