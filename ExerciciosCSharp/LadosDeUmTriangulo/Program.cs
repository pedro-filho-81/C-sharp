using System;

namespace LadosDeUmTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            // variáveis
            int ladoA, ladoB, ladoC;
            int sentinela = 1;

            // enquando sentinela diferente e 1 faça
            while( sentinela != -1 )
            {       
                Console.Clear(); // limpa a tela

                // entrada de dados
                Console.Write("Digite o ladoA do triângulo: " );
                ladoA = int.Parse(Console.ReadLine());
                
                // entrada de dados
                Console.Write("Digite o ladoB do triângulo: " );
                ladoB = int.Parse(Console.ReadLine());
                
                // entrada de dados
                Console.Write("Digite o ladoC do triângulo: " );
                ladoC = int.Parse(Console.ReadLine());
                
                // se a menor que b mais c b < c + a e c < a + b
                if( ladoA < ladoB + ladoC && ladoB < ladoA + ladoC && 
                    ladoC < ladoA + ladoB) // se verdade
                {
                    // imprima
                    Console.WriteLine($"A = {ladoA}, B = {ladoB}, C = {ladoC} " +
                        $"\nPode ser um triângolo.");
                } // fim if
                else // se não
                {
                    // imprima
                    Console.WriteLine($"A = {ladoA}, B = {ladoB}, C = {ladoC} " +
                        $"\nNão pode ser um triângolo.");
                } // fim else

                System.Console.Write("Deseja continuar? [ 1=sim / -1=não ]");
                sentinela = int.Parse(Console.ReadLine());

            } // fim while

            // limpa a tela
            Console.Clear();
        } // fim main
    } // fim classe
} // fim namespace
