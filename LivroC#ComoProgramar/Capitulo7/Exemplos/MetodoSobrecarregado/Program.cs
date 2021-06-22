using System;

namespace MetodoSobrecarregado
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Console.Clear();

            // cria variável
            int numInteiro = 7;
            double numDouble = 7.5;

            // cabeçalho
            Console.WriteLine("SOBRECARGA DE MÉTODOS" );
            
            // mostra resultado
            Console.WriteLine($"O valor do número {numInteiro} no método" +
                            $" QuadradoDoNumero é {QuadradoDoNumero(numInteiro)}");
            
            Console.WriteLine($"O valor do número {numDouble} no método" +
                            $" QuadradoDoNumero é {QuadradoDoNumero(numDouble)}");
        } // fim main

        // cria o método QuadradoDoNumero
        static int QuadradoDoNumero( int numero )
        {
            return numero * numero;
        } // fim método QuadradodoNumero

        
        // cria o método QuadradoDoNumero
        static double QuadradoDoNumero( double numero )
        {
            return numero * numero;
        } // fim método QuadradodoNumero
    } // fim classe
} // fim namespace
