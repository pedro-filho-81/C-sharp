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
            int[] vetor = {3, 5, 7, 1, 8, 9, 1, 2, 4, 2, 1 };

            // cabeçalho
            WriteLine("Distribuição das notas");

            // loop para cada elemento do vetor mostre a barra de caractere
            for( int contar = 0; contar < vetor.Length; ++contar )
            {
                // se contar igual a 10 imprima 100
                if( contar == 10 )
                {
                    // imprima
                    WriteLine(" 100: ");
                } // fim if
                else // se não
                {
                    // imprima
                    Write($"{contar * 10:D2}-{contar * 10 + 9:D2}: ");
                    
                    // loop para mostrar as barras de asterisco
                    for( int estrelas = 0; estrelas < vetor[ contar ]; ++estrelas )
                    {
                        Write("*"); // imprima

                    } // fim for asterisco

                    WriteLine(); // pula linha

                } // fim else
           
            } // fim for
            
            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim namespace
