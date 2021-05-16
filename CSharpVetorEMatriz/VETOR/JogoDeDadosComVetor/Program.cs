using System;

namespace JogoDeDadosComVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria o vetor para 6 elementos
            int[] frequencia = new int[ 7 ];
           
            // cria o objeto para Random
            Random numeroAleatorio = new Random();
           
            // cria variável
            double soma = 0;

            // limpa a tela
            Console.Clear();

            // loop for para somar o elemento da frequência
            for( int lancaDados = 1;  lancaDados <= 6000000; lancaDados++ )
            {
                ++frequencia[ numeroAleatorio.Next( 1, 7 ) ];
            } // fim for

            // loop for
            for( int i = 1; i < 7; i++ )
                soma += frequencia[ i ];

            // cabeçalho
            Console.WriteLine("Índice\tFrequência\tPercentual" );

            // loop para
            for( int lado = 1; lado < frequencia.Length; lado++ )
            {
                // imprime resultado
                Console.WriteLine($"{lado, 2} {frequencia[lado], 15} {frequencia[lado] / soma * 100, 13:N3}%" );
            } // fim for
            
        } // fim main
    } // fim classe
} // fim namespace
