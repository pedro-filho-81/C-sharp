using System;
using static System.Console;

namespace RolandoDados7
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria objeto randômico
            Random numeroAleatorio = new Random();

            // cria vetor
            var frequencia = new int[ 7 ];

            // loop para lolar dado verias vezes
            for( var rolar = 1; rolar <= 600000; rolar++ )
            {
                ++frequencia[ numeroAleatorio.Next( 1, 7 ) ];
            } // fim for

            // cabeçalho
            WriteLine($"{"FAce"}{"Frequência", 15}" );

            // loop para mostrar os valores da face e da frequência
            for( var face = 1; face < frequencia.Length; face++ )
            {
                WriteLine($"{face, 4}{frequencia[ face ], 15}" );
            } // fim for

            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim namespace
