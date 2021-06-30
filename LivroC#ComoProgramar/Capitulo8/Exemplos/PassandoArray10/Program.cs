using System;
using static System.Console;

namespace PassandoArray10
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria vetor
            int[] vetor = {1, 2, 3, 4, 5 };

            // imprima
            WriteLine("Efeito da passagem por referência entre arrays.");
            WriteLine($"Valores do vetor original:");

            // loop para mostrar valores
            foreach( var valores in vetor )
            {
                Write($"{valores} " );
            } // fim foreach

            // chama o método modifica array
            ModificaArray(vetor);

            WriteLine($"\n\nOs valores do vetor modificado é:" );

            foreach( var valores in vetor )
            {
                Write($"{valores} " );
            } // fim foreach

            // mostrar
            WriteLine($"O valor do vetor[ 3 ] = {vetor[ 3 ]}");
            
            ModificarElemento( vetor[3] );
            WriteLine($"\nO valor do elemento vetor[ 3 ] é {vetor[ 3 ]}" );

            Console.WriteLine("\nHello World!");
        } // fim main

        static void ModificaArray(int[] vetor1 )
        {
            for( int contar = 0; contar < vetor1.Length; contar++ )
            {
                vetor1[contar] *= 2;
            } // fim for
        } // fim método

        static void ModificarElemento( int vetor2 )
        {
            vetor2 *= 2;
        } // fim método

    } // fim classe
} // fim namespace
