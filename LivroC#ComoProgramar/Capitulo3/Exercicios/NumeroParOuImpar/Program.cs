using System;

namespace NumeroParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Console.Clear();

            // entrada de dados
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            // se o número multiplo de 2
            if( numero % 2 == 0 )
            {
                Console.WriteLine($"{numero} É PAR.");
            } // FIM IF

            if( numero %2 != 0 )
            {
                Console.WriteLine($"{numero} É ÍMPAR.");
            } // fim if
            
        } // fim main
    } // fim classe
} // fim name
