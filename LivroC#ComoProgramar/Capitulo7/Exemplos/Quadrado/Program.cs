using System;

namespace Quadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Console.Clear();

            // cria variável
            int numero = 10;

            Console.WriteLine($"O valor do número {numero} " +
                            $"no método QuadradoDoNumero é {QuadradoDoNumero(numero)}");
        } // fim main

        // cria o método QuadradoDoNumero
        static int QuadradoDoNumero( int numero )
        {
            return numero * numero;
        } // fim do método
    } // fim da classe
} // fim do namespace
