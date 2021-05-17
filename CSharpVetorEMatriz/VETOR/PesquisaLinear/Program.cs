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

            // cria a variável 
            int resposta = 0;

            // cria vetor
            int[] vetor = new int[ TAMANHO ];
            
            // CHAMA o método adicionar valores
            AdicionarValores(vetor, TAMANHO );

            // cabeçalho
            WriteLine("Vetor Original" );

            // chama o método mostrar valores
            MostrarValores( vetor ); // mostra os vetor original

            // chama método pesquisar valor
            resposta = PesquisaLinear( vetor, 10 );

            // chama o método Resposta da pesquisa
            RespostaDaPesquisa( resposta );

            // cabeçalho
            WriteLine( "VETOR ORGANIZADO" );

            // chama o método organizar valor
            OrganizarValores(vetor, TAMANHO );

            // chama o método mostrar valores
            MostrarValores( vetor );

            // chama o método pesquisar
            resposta = PesquisaLinear( vetor, 20 );

            // chama a função resposta da pesquisa
            RespostaDaPesquisa( resposta );

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
            // loop para posição do vetor
            for( int i  = 0; i < vetor.Length; i++ )
            {
                // se o valor for encontrado
                if( vetor[ i ] == pesquisa )
                {
                    // retorne a posição em que ele se encontra
                    return i;                   
                } // fim if
            } // fim for

            // retorne -1 se o valor não for encontrado
            return -1;

        } // fim método pesquisar

        // cria método resposta da pesquisa
        static void RespostaDaPesquisa( int resposta )
        {            
            // Se resposta diferente de -1
            if( resposta != -1 )
                // imprima
                WriteLine( $"Valor encontrado na posição {resposta}" );
            // se não
            else
                // imprima
                WriteLine( "Valor não encontrado" );
        } // fim função resposta da pesquisa

    } // fim classe
} // fim namespace
