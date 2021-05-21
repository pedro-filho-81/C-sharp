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

            // cria o vetor frequência
            int[] frequencia = new int[ 10 ];

            // chama a função adicionar valores
            AdicionarValores( resposta, TAMANHO );

            // cabeçalho
            Write("Vetor original:" );

            // chama o método mostrar valores
            MostrarValores( resposta, TAMANHO );

            // chama o método média
            CalcularMedia( resposta, TAMANHO );

            // chama o método mediana
            CalcularMediana( resposta, TAMANHO );

            // chama método moda
            CalcularModa( resposta, TAMANHO, frequencia );

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
                if( numero % 20 == 0 )
                    // pula uma linha
                    WriteLine();

                // imprima o elemento do vetor da posição número
                Write( $"{vetor[ numero ]} " );

            } // fim for
        } // fim mostrar valores

        // cria o método calcular média
        static void CalcularMedia( int[] vetor, int tamanho )
        {
            // cria variável
            int total = 0;

            // cabeçalho
            WriteLine("\n***** MÉDIA *****" );

            // loop para somar os valores do vetor
            foreach( int numero in vetor )
            {
                // soma os números
                total += numero;
            } // fim foreach

            // imprime a média
            WriteLine($"Média: {total} / {tamanho} = {total / tamanho}" );
        } // fim método calcular média

        // cria o método calcular a meniana
        static void CalcularMediana( int[] vetor, int tamanho )
        {
            // cabeçalho
            WriteLine("\n***** MEDIANA *****" );

            // chama o método ordenar vetor
            OrdenarVetor( vetor, tamanho );

            // cabeçalho
            Write("***** VETOR ORDENADO *****" );

            // chama o método mostrar valores
            MostrarValores( vetor, tamanho );

            // imprima
            WriteLine($"\n\nA mediana é o elemento {tamanho / 2}\n" + 
                    $"vetor ordenado de {tamanho}.\n" +
                    $"Para essa execução, a mediana é {vetor[ tamanho / 2 ]}\n");

        } // fim calcular mediana

        // CRIA método ordenar vetor
        static void OrdenarVetor( int[] vetor, int tamanho )
        {
            // cria a variável auxiliar
            int auxiliar = 0;

            // loop para contar as passadas
            for( int passadas = 1; passadas < tamanho; passadas++ )
            {
                // loop para compara o número de comparações
                for( int i = 0; i < tamanho - 1; i++ )
                {
                    // troca os elementos se estiverem fora da ordem
                    if( vetor[ i ] > vetor[ i + 1 ] )
                    {
                        auxiliar = vetor[ i ];
                        vetor[ i ] = vetor[ i + 1 ];
                        vetor[ i + 1 ] = auxiliar;
                    } // fim if

                } // fim for interno

            } // fim for passadas
        } // fim função ordenar

        // cria método moda
        static void CalcularModa( int[] vetor, int tamanho, int[] frequencia )
        {
            // cria variáveis
            int contaElementos;
            int j;
            int h;
            int maior = 0;
            int respMaisFrequente = 0;

            // cabeçalho
            WriteLine( "\n***** Valor Modal *****" );

            // loop para inicializar a frequência em zero
            for( contaElementos = 0; contaElementos <= 0; contaElementos++ )
            {
                frequencia[ contaElementos ] = 0;

            } // fim for conta elementos

            // loop resumo da frequencia
            for( j = 0; j < tamanho; j++ )
            {
                ++frequencia[ vetor[ j ] ];
            } // fim for j

            // cabeçalho
            WriteLine( $"{"Resposta"}{"Frequência", 11}{"Histograma", 13}" );

            // loop para mostra resultado
            for( contaElementos = 1; contaElementos <= 9; contaElementos++ )
            {
                // mostra resultado
                Write( $"{contaElementos, 5}{frequencia[ contaElementos ], 10}" );

                // acompanha o valor da moda e o valor da maior frequência
                if( frequencia[ contaElementos ] > maior )
                {
                    maior = frequencia[ contaElementos ];
                    respMaisFrequente = contaElementos;
                } // fim if

                Write( "       " );

                // loop para o histograma
                for( h = 0; h <= frequencia[contaElementos]; h++ )
                {
                    Write( $"*" );
                } // fim for histograma

                WriteLine(); // pula linha

            } // for externo

            // imprime resultado
            WriteLine($"A moda é o valor mais frequente.\n" +
                    $"Para essa execução, a moda é {respMaisFrequente}, " + 
                    $"que ocorreu {maior} vezes." );
        } // fim método moda

    } // fim classe
} // fim name space
