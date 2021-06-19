using System;
using static System.Console;

namespace NumerosAleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria o objeto aleatório
            Random numerosAleatorios = new Random();

            // loop for
            for( int i = 1; i <= 20; i++ )
            {
                int face = numerosAleatorios.Next( 1, 7 );
                Write($"{face} " );
            } // fim fir



            Console.WriteLine("Hello World!");
        }
    }
}
