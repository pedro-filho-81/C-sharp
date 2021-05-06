using System;
using static System.Console;

namespace CartasDoBaralho
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria variável objeto para a classe baralho de cartas
            var meuBaralhoDeCartas = new ClasseBaralhoDeCartas();
            
            // objeto meu baralho de carta chama o método embaralhar
            meuBaralhoDeCartas.Embaralhar();

            // loop para mostrar as cartas embaralhadas
            for( var i = 0; i < 52; i++ )
            {
                // imprime
                Write($" {meuBaralhoDeCartas.DistribuirUmaCarta(), 20} " );

                // quando for multiplos de 4
                if( (i + 1) % 4 == 0 )
                {
                    // pule uma linha
                    System.Console.WriteLine();
                } // fim if

            } // fim for

        } // fim main
    } // fim classe
} // fim namespace
