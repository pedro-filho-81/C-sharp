using System;
using static System.Console;

namespace PesquisaEstudantes
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa  a tela
            Clear();

            // cria vetor
            int[] resposta = { 1, 2, 2, 1, 4, 4, 3, 3, 5, 4, 1, 1, 3, 2, 2, 4, 3, 14 };

            // cria frequência
            var frequencia = new int[ 6 ];

            // loop 
            for( var resp = 0; resp < resposta.Length; resp++ )
            {
                try
                {
                    ++frequencia[ resposta[ resp ] ];
                } // fim try
                catch( IndexOutOfRangeException )
                {
                    WriteLine("O índice estava fora dos limites da matriz.");
                    WriteLine($"resposta[{resp}]{resposta[resp]}\n" );
                } // fim catch

            } // fim for

            // cabeçalho
            WriteLine($"{"Nota:"}{"Frequência",12}" );

            // loop para mostrar a nota e a frequência
            for( var avaliacao = 1; avaliacao < frequencia.Length; avaliacao++ )
            {
                WriteLine($"{avaliacao, 4}{frequencia[ avaliacao], 8}" );
            } // fim loop for

            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim namespace
