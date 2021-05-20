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
    } // fim classe
} // fim name space
