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

            // cria a variável 
            int resposta = 0;
            int chave = 0;

            // CHAMA o método adicionar valores
            AdicionarValores(vetor, TAMANHO );
                        
            // cabeçalho
            WriteLine("Vetor Original" );
            // chama o método mostrar valores
            MostrarValores( vetor ); // mostra os vetor original
                        
            // cabeçalho
            WriteLine( "VETOR ORGANIZADO" );
            // chama o método organizar valor
            OrganizarValores(vetor, TAMANHO );
            // chama o método mostrar valores
            MostrarValores( vetor ); // mostra os vetor original
            
            // entrada de dados
            Write( "Digite um número entre 1 e 50: " );
            chave = int.Parse(ReadLine());

            // chama a função imprime cabeçalho
            ImprimaCabecalho( vetor );

            // chama método pesquisar valor
            resposta = PesquisaBinaria(vetor, chave, 0, TAMANHO - 1 );

            // chama o método Resposta da pesquisa
            RespostaDaPesquisa( resposta );

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

        // cria método pesquisa binária
        static int PesquisaBinaria( int[] vetor, int pesquisa, int inicio, int fim )
        {
            // cria variáveis
            int meio = 0;

            // enquanto inicio menor ou igual ao fim
            while( inicio <= fim )
            {
                meio = ( inicio + fim ) / 2;

                // imprime uma linha
                ImprimaLinha(vetor, inicio, meio, fim );

                // se pesquisa igual ao vetor
                if( pesquisa == vetor[ meio ] )
                {
                    // retorne a posição encontrada
                    return meio;
                } // fim if

                else if( pesquisa < vetor[ meio ] )
                {
                    fim = meio - 1;
                } // fim else if
                
                else
                {
                    inicio = meio + 1;
                } // fim else                

            } // fim wile

            // retorne -1 se o valor não encontrado
            return -1;

        } // fim do método pesauisa binária

        // cria método imprime cabeçalho
        static void ImprimaCabecalho( int[] vetor )
        {
            // cria variável
            int contador;

            WriteLine("Subscrito\n" );

            // loop cabeçalho para coluna
            for( contador = 0; contador < vetor.Length; contador++ )
            {
                Write( $"{ contador, 3} " );
            } // fim for

            WriteLine(); // pula linha

            // loop para linha de comando
            for( contador = 1; contador <= 4 * vetor.Length; contador++ )
            {
                Write( "_" );
            } // fim for

            WriteLine(); // pula linha

        } // fim método imprime cabeçalho

        // cria método imprima linha
        static void ImprimaLinha( int[] vetor, int inicio, int meio, int fim )
        {
            // cria variável
            int contador;

            // loop pelo vetor
            for( contador = 0; contador < vetor.Length; contador++ )
            {
                if( contador < inicio || contador > fim )
                    Write(" ");
                else if( contador == meio )
                    Write( $"{vetor[ contador ], 3}*" );
                else
                    Write( $"{vetor[ contador ], 3}" );

            } // fim for

            WriteLine(); // pula uma linha

        } // fim método imprima linha
        
    } // fim classe
} // fim namespace
