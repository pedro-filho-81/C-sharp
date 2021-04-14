using System;

namespace Misterio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int linha = 10;
            while( linha >= 1 )
            {
                int coluna = 1;
                while( coluna <= 10 )
                {
                    System.Console.WriteLine(linha % 2 == 1 ? "<" : ">" );
                    coluna++; // soma 1 a coluna
                }

                --linha; // subitrai 1 de linha
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
