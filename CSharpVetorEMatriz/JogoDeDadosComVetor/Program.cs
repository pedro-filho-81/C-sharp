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
           
            // limpa a tela
            Console.Clear();

            // loop for para somar o elemento da frequência
            for( int lancaDados = 1;  lancaDados< 6000000; lancaDados++ )
            {
                ++frequencia[ numeroAleatorio.Next( 1, 7 ) ];
            } // fim for

            // cabeçalho
            Console.WriteLine("Face\tFrequência" );

            // loop para
            for( int lado = 1; lado < frequencia.Length; lado++ )
            {
                Console.WriteLine($"{lado, 2} {frequencia[lado], 15}" );
            } // fim for
            
        } // fim main
    } // fim classe
} // fim namespace
