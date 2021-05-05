using System;
using static System.Console;

namespace GraficoDeBarras
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria um vetor com as notas
            int[] vetor = {5, 3, 4, 0, 0, 0, 9, 7, 2, 6 };

            // CABEÇALHO
            WriteLine("DISTRIBUIÇÃO DAS NOTAS");

            // loop de
            for( var contar = 0; contar < vetor.Length; ++contar )
            {
                // se contar igual a 10
                if( contar == 10 )
                {
                    // escrava 100
                    Write("100");
                } // fim if
                else // se não
                {
                    // escreva
                    Write( $"{contar * 10:D2} - {contar * 10 + 9:D2}" );
                } // fim se não

                // mostra barra de asterisco
                for( int mostrar = 0; mostrar < vetor[ contar ]; mostrar++ )
                {
                    // escreva asterisco
                    Write("*");
                } // fim for

                WriteLine(); // pula uma linha
                
            } // fom for
        } // fim main
    } // fim classe
} // fim namespace
