using System;

namespace EquivalenteBinarioDeDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDecimal = 0;
            int contador = 1;

            // entre com um inteiro
            System.Console.Write("Entre com um número inteiro: ");
            numDecimal = int.Parse(Console.ReadLine());

            while( numDecimal / 2 != 0 )
            {
                //numDecimal %= 2;
                System.Console.WriteLine($"{numDecimal}");
                //numDecimal /= 2;

                contador++;
            }

            Console.WriteLine("Hello World!");
        }
    }
}
