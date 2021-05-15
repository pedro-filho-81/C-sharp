using System;
using static System.Console;

namespace ColocandoElementosNoVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria uma constante
            const int TAMANHO = 10;
            
            // cria um vetor
            int[] numeros = new int[ TAMANHO ];

            // loop para adicionar valores ao vetor
            for( int i = 0; i < TAMANHO; i++ )
            {
                // adicionando valores ao vetor
                numeros[ i ] = 2 + 2 * i;
            } // fim for

            // cabeçalho
            WriteLine($"{"Ìndice"}{"Valor", 8}" );

            // loop para mostrar os valores do vetor
            for( int j = 0; j < TAMANHO; j++ )
            {
                // mostra índice e os elemsntos do vetor
                WriteLine($"{j, 3}{numeros[ j ], 10}" );
            } // fim for

            Console.WriteLine("Hello World!");
        }
    }
}
