using System;

namespace AnalisandoUmaPesquisa
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria objeto randômico número aleatório
            Random numeroAleatorio = new Random();

            // cria vetor respostas para as resposta da pesquisa
            int[] resposta = new int[ 40 ];

            // cria vetor frequência para verifica quantas vezes 
            // deram a mesma resposta
            int[] frequencia = new int[ 11 ];

            Console.Clear(); // limpa a tela
            
            // cabeçalho
            Console.Write( "  VALORES RESPOSTA DA PESQUISA" );
                        
            // loop para adicionar 40 valores ao vetor resposta
            for( int i = 0; i < 40; i++ )
            {
                // vetor resposta recebe 40 números aleatórios entre 1 e 10 inclusive
                resposta[ i ] = numeroAleatorio.Next(1, 12);
                
                // pula uma linha se i for multiplo de 10
                if( i % 10 == 0)
                    // pula uma linha
                    System.Console.WriteLine();
                
                // imprima o valor do vetor da posição i
                Console.Write($"{resposta[ i ], 3}" );

            } // fim for adicionar
                         
            // loop para contar a frequêcia dos valores de resposta
            for( int j = 0; j < resposta.Length; j++ )
            {
                try
                {
                    // verifica quantas vezes um valor no vetor resposta apareceu
                    ++frequencia[ resposta[ j ] ];
                } // fim try
                catch(IndexOutOfRangeException)
                {
                    Console.WriteLine($"\nO índice está fora dos limites da matriz.");
                    Console.WriteLine($"resposta[{j}] = {resposta[j]}\n");
                }

            }

            // cabeçalho da tabela
            Console.WriteLine( "\n  Valor\tApareceu" );

            // loop para mostrar os valores
            for( int i = 1; i < frequencia.Length; i++ )
            {
                // imprime o índice e a frequência que o valor aprece
                Console.WriteLine($"{i, 3} {frequencia[ i ], 10}" );
            } // fim for

        }// fim main
    } // fim classe
} // fim namespace
