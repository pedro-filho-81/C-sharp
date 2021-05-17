using System;
using static System.Console;

namespace PesquisaLinear
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa tela
            Clear();

            // CRIA constante
            const int TAMANHO = 10;

            // cria vetor
            int[] vetor = new int[ TAMANHO ];
            
            // CHAMA o método adicionar valores
            AdicionarValores(vetor, TAMANHO );

            // cabeçalho
            WriteLine("Vetor Original" );

            // chama o método mostrar valores
            MostrarValores( vetor );

            // chama método pesquisar valor
            PesquisaLinear( vetor, 10 );

            // cabeçalho
            WriteLine( "VETOR ORGANIZADO" );

            // chama o método organizar valor
            OrganizarValores(vetor, TAMANHO );

            // chama o método mostrar valores
            MostrarValores( vetor );

            // chama o método pesquisar
            PesquisaLinear( vetor, 20 );

            Console.WriteLine("Hello!");
        } // fim main

        // cria método adicionar valores
        static void AdicionarValores( int[] vetor, int tamanho )
        {            
            // cria objeto para
            Random numerosAleatorios = new Random();

            // loop para adicionar valores ao vetor
            for( int i = 0; i < tamanho; i++ )
            {
                // adiciona um número aleatório entre 1 e 50 no vetor
                vetor[i] = numerosAleatorios.Next(1, 50 );
            } // fim for
        } // fim método adicionar valores

        // cria método Mostra valores
        static void MostrarValores( int[] vetor )
        {
            // imprime
            Write("vetor = {" );

            // loop para mostrar os valores
            foreach( var elementos in vetor )
            {
                // imprime os elementos do vetor
                Write($" {elementos}");
            } // fim foreach

            // imprime
            WriteLine(" }" );
        } // fim método mostrar

        // cria organizar valores
        static void OrganizarValores( int[] vetor, int tamanho )
        {
            // cria variável auxiliar
            int auxiliar;

            // cria loop para organizar os valores do vetor
            for( int i = 1; i < tamanho; i++ )
            {
                // loop para organizar
                for( int j = 0; j < tamanho - 1; j++ )
                {
                    if( vetor[ j ] > vetor[ j + 1 ] )
                    {
                        auxiliar = vetor[ j ];
                        vetor[ j ] = vetor[ j + 1 ];
                        vetor[ j + 1 ] = auxiliar;

                    } // fim if

                } // fim for interno
            } // fim for externo
        } // fim método organizar

        // CRIA uma pesquisa linear
        static int PesquisaLinear( int[] vetor, int pesquisa )
        {
            for( int i  = 0; i < vetor.Length; i++ )
            {
                if( pesquisa == vetor )
                {
                    
                }
            }
        } // fim método pesquisar

    } // fim classe
} // fim namespace
