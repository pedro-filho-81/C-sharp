using System;
using static System.Console;

namespace ManipulacaoDeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria e eincializa um array
            double[] doubleArray = { 8.9, 9.3, 0.2, 7.9, 3.4, 6.5, 4.2 };
            
            // imprime o array original
            WriteLine( $"Vetor original" );
            Write($"doubleArray: " );
            
            // para cada valor em doubleArray
            foreach( var valor in doubleArray )
                // imprima o valor
                Write($"{valor, 1} " );

            // organiza doublearray
            Array.Sort( doubleArray );
            
            // cabeçalho
            WriteLine("\nArray organizado:" );

            // imprime
            Write( "doubleArray: " );
            
            // loop para mostra os valores do array
            foreach( var valor in doubleArray )
            {
                // imprima o valor
                Write( $"{valor, 1} " );
            } // fim foreach

            // cria um array para 10 elementos
            int[] arrayComZeros = new int[10];
            
            // cabeçalho
            WriteLine("\nVetor com zeros" );
            Write($"arrayComZeros: " );
            
            // para cada posição em arrayComZeros
            foreach( var valor in arrayComZeros )
                // imprima zero
                Write( $"{valor} " );            

            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim namespace
