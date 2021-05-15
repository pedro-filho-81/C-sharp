using System;
using static System.Console;

namespace SomandoValores
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria número aleatório
            Random numero = new Random();

            // cria uma aconstante
            const int TAMANHO = 10;

            // cria uma variável
            int total = 0;

            // cria um vetor
            int[] vetor = new int[ TAMANHO ];

            // atribuir valores
            for( int i = 0; i < TAMANHO; i++ )
            {
                // atribui valores aleatórios ao vetor
                vetor[ i ] = numero.Next( 1, 50);
            } // fim for
            
            // loop para somar valores do vetor
            for( int j = 0; j < TAMANHO; j++ )
            {
                // soma os valores do vetor
                total += vetor[ j ];
            } // fim for

            // cabeçalho
            WriteLine($"Ìndice{"Valor", 10}" );

            // loop para mostra os elementos do vetor
            for( int mostrar = 0; mostrar < TAMANHO; mostrar++ )
            {
                // mostrar resultado
                WriteLine($"{mostrar + 1, 3}{vetor[ mostrar ], 10}" );
            } // fim for

            // imprima
            Console.WriteLine($"Total = {total}");
        } // fim main
    }// fim classe
} // fim namespace
