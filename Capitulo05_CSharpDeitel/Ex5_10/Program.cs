using System;

namespace Ex5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <=10; i++ )
            {
                for( int j = 1; j <= 5; j++ )
                    System.Console.WriteLine('@');

                System.Console.WriteLine();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
