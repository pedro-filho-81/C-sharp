using System;

namespace TabuleiroDeDamas
{
    class Program
    {
        static void Main(string[] args)
        {
            // variável
            int linha = 0;
            int coluna = 0;

            // enquanto linha menor que 10
            while( linha < 10 )
            {
                // enquanto coluna menor que 10
                while( coluna < 10 )
                {
                    // imprima asterisco
                    System.Console.Write("* ");
                    coluna++; // incrementa 1
                } // fim while coluna

                // nova linha
                System.Console.WriteLine();

                // se linha for par
                if( linha % 2 == 0 ) // se verdade
                {
                    // imprima um espaço vazio
                    System.Console.Write(" ");
                } // fim if
                
                // incremento soma 1 a linha
                linha++;
                // inicializa a coluna
                coluna = 0;
            } // fim while externo
        } // fim main
    } // fim classe 
} // fim namespace
