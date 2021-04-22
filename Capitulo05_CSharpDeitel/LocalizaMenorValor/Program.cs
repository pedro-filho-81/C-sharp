using System;

namespace LocalizaMenorValor
{
    class Program
    {
        /*
            5.11 (Localize o menor valor) Escreva um aplicativo que localiza o menor de 
            vários números inteiros. Suponha que o primeiro valor lido  especifica o número 
            de valores a serem inseridos pelo usuário. 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 154). Edição do Kindle. 
            Autor: Pedro Filho, 22/04/2021
        */
        static void Main(string[] args)
        {
            // cria variáveis
            int num = 0;
            int quantidadeDeNumero = 0;
            int menorValor = 0;
            int sentinela = 1;

            // repete enquanto sentinela diferente de -1
            while( sentinela != -1 )
            {
                Console.Clear();  // limpa a tela

                // entrada de dados
                System.Console.Write("Quantos números deseja cadastrar? ");
                quantidadeDeNumero = int.Parse(Console.ReadLine());

                // loop para inserir números conforma a quantidade de números
                for( int i = 1; i <= quantidadeDeNumero; i++ )
                {
                    // entrada dos números
                    System.Console.Write($"Digite o {i}º número: " );
                    num = int.Parse(Console.ReadLine());

                    // se for o primeiro número
                    if( i == 1 )
                        // menor valor recebe o número
                        menorValor = num;

                    // se o número for menor que o menor valor
                    if( num < menorValor )
                        // menor valor recebe o número
                        menorValor = num;
                } // fim for

                // mostra resultado
                Console.WriteLine($"O menor valor é {menorValor}.");

                // perqunta se quer continuar
                System.Console.WriteLine($"Deseja continuar? [ 1=sim / -1=não ] ");
                sentinela = int.Parse(Console.ReadLine());
                
            } // fim while
            
            Console.Clear(); // limpa a tela

        } // fim main
    } // fim classe
} // fim namespace
