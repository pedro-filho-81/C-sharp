using System;
using static System.Console;

namespace TerceiroVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTE INTEIRA
            const int TAMANHO = 10;
            // cria variável para um vetor
            int[] vetor = new int[TAMANHO];

            // loop para adicionar valores ao vetor
            for( int adicionar = 0; adicionar < TAMANHO; adicionar++ )
            {
                // vetor recebe os valores
                vetor[ adicionar ] = 2 + 2 * adicionar;
            } // fim loop adicionar

            // cabeçalho
            WriteLine($"Índice{"Valor", 8}" );

            // loop para mostrar valores do vetor
            for(int mostrar = 0; mostrar < TAMANHO; mostrar++ )
            {
                // imprima
                WriteLine( $"   {mostrar + 1, 3} {vetor[mostrar], 5}" );
            } // fim loop mostrar

        } // fim main
    } // fim classe
} // fim namespace
