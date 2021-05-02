using System;

namespace TerceiroVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria uma constante
            const int TAMANHO = 10;
            // cria um vetor
            int[] vetor = new int[TAMANHO];

            Console.Clear(); // limpa a tela

            // LOOP PARA ADICIONAR VALOR NO VETOR
            for( int contar = 0; contar < TAMANHO; contar++ )
            {
                // vetor recebe os valores
                vetor[contar] = contar * 2;
            } // fim for

            // imprime cabeçalho
            Console.WriteLine($"Vetor {"Valor", 10}");

            // loop para mostrar os valores do vetor
            for( int mostrar = 0; mostrar < TAMANHO; mostrar++ )
            {
                // imprime os valores do vetor
                Console.WriteLine( $"{mostrar + 1, 3} {vetor[mostrar], 10}" );
            } // fim for mostrar

        } // fim main
    } // fim classe
} // fim namespace
