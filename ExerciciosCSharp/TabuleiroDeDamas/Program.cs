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
                    // imprima
                    System.Console.Write("* ");
                    coluna++; // incrementa 1
                }

                System.Console.WriteLine();

                if( linha % 2 == 0 )
                {
                    System.Console.Write(" ");
                }
                
                linha++;
                coluna = 0;
            }
        }
    }
}
