using System;
using static System.Console;

namespace InstrucaoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria uma constante
            const int TAMANHO = 10;
            // cria vetor
            int[] vetor = new int[ TAMANHO ];
            // cria objeto randômico
            Random numeroAleatorio = new Random();
            // cria variável
            int total = 0;

            // loop para adicionar valor
            for(int i = 0; i < TAMANHO; i++ )
            {
                // atribui valores ao vetor
                vetor[ i ] = numeroAleatorio.Next( 50 );
            } // fim for

            // cabeçalho
            WriteLine($"{"Valores"}" );

            // loop para somar os valores do vetor
            foreach( int valor in vetor )
            {
                // mostra os valores do vetor
                Write($"{valor} " );
                // soma os valores do vetor
                total += valor;
            } // fim foreach

            // mostra resultado
            Console.WriteLine($"\ntotal = {total}");
        } // fim main
    } // fim classe
} // fim namespace
