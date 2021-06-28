using System;
using static System.Console;

namespace CriandoBarras6
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria vetor e inicializa
            int[] vetor = {0, 0, 0, 0, 0, 0, 1, 2, 4, 2, 1 };

            WriteLine("Distribuição das notas");

            // para cada elemento do vetor mostre a barra de caractere
            for( int contar = 0; contar < vetor.Length; contar++ )
            {
                // se contar igual a 10 imprima 100
                if( contar == 10 )
                {
                    WriteLine(" 100: ");
                } // fim if
                else
                {
                    Write($"{contar * 10:D2}-{contat * 10 + 9:D2}: ");
                }
            } 
            Console.WriteLine("Hello World!");
        }
    }
}
