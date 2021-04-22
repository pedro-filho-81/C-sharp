using System;

namespace ProdutoDosInteirosImpares
{
    class Program
    {
        /*
            5.12 (Calculando o produto de números inteiros ímpares) Escreva um aplicativo 
            que calcula o produto dos números inteiros ímpares de 1 a 15. 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 154). Edição do Kindle. 
            Autor: Pedro Filho, 22/04/2021
        */
        static void Main(string[] args)
        {
            // cria variável
            int produto = 1;

            // CABEÇALHO
            System.Console.WriteLine("O PRODUTO DOS NÚMEROS ÍMPARES DE 1 A 15");
            
            // loop para contar de 1 a 15
            for( int i = 1; i <= 15; i++ )
            
                // se i % 2 == 1 ( se i for ímpar )
                if( i % 2 == 1 )
                {          
                    System.Console.Write($"{i} x ");      
                    // calcular o valor
                    produto *= i;
                } // fim if
            
            // imprima o resultado    
            Console.WriteLine( $"\b\b = {produto}" );
            
            Console.ReadKey();
            Console.Clear();
            
        } // FIM MAIN
    } // FIM CLASSE
} // FIM NAMESPACE
