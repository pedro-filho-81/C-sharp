using System;
using static System.Console;

namespace EmbaralharCartas9
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();
            // cabeçalho
            WriteLine("EMBARALHAR CARTAS" );

            // cria objeto DA classe baralho de cartas
            var meuBaralhoDeCartas = new BaralhoDeCartas();
            // objeto chama o método embaralhar
            meuBaralhoDeCartas.Embaralhar();

            // loop para dar as cartas
            for( int i = 0; i < 52; i++ )
            {
                // mostra cartas alinhado a esquerda com 25 espaços
                Write($"{meuBaralhoDeCartas.DarCartas(), -25}" );

                // se multiplo de quatro
                if( ( i + 1) % 4 == 0 )
                {
                    // pule uma linha
                    WriteLine();
                } // fim if

            } // fim for                                    
            
        } // fim main
    } // fim classe
} // fom namespace
