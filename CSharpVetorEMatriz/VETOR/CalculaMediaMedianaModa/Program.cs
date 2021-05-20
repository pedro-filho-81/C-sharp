using System;
using static System.Console;

namespace CalculaMediaMedianaModa
{
    class Program
    {
        /* Figura 6.16: fig06_16.c  2 
        Esse programa introduz o tópico da análise de dados de pesquisa.  
        3 Ele calcula a média, a mediana e a moda dos dados 
        Deitel, Paul; Deitel, Harvey. C  Como Programar (p. 181). Edição do Kindle. */
        static void Main(string[] args)
        {
            // limpa a atela
            Clear();

            // cria uma constante para controle do vetor
            const int TAMANHO = 99;

            // CRIA o vetor para números
            int[] resposta = new int[ TAMANHO ];

            // chama a função adicionar valores
            AdicionarValores( resposta, TAMANHO );

            // cabeçalho
            Write("Vetor original:" );
            // chama o método mostrar valores
            MostrarValores( resposta, TAMANHO );

            Console.WriteLine("Hello World!");
        } // fim main

        // cria o método adicionar valores
        static void AdicionarValores( int[] vetor, int tamanho )
        {
            // cria o objeto randon
            Random numeros = new Random();

            // loop para adicionar valores ao vetor
            for( int i = 0; i < tamanho; i++ )
            {
                // adiciona valores aleatórios ao vetor
                vetor[ i ] = numeros.Next( 1, 10 );
            } // fim for
        } // fim método atribuir valores

        // cria método mostrar valores
        static void MostrarValores( int[] vetor, int tamanho )
        {
            // loop para mostrar valores do vetor
            for( int numero = 0; numero < tamanho; numero++ )
            {
                // se número multiplo de 10
                if( numero % 10 == 0 )
                    // pula uma linha
                    WriteLine();

                // imprima o elemento do vetor da posição número
                Write( $"{vetor[ numero ]} " );

            } // fim for
        } // fim método

    } // fim classe
} // fim name space
