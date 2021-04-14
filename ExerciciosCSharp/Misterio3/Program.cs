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
            int x = 5;
            int y = 7;
            if( x == 5)
            if( y == 8 )
            System.Console.WriteLine("*****");
            else
            System.Console.WriteLine("#####");
            System.Console.WriteLine("$$$$$");
            System.Console.WriteLine("69696");

            Console.WriteLine("Hello World!");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
