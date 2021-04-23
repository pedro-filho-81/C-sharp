using System;
using static System.Console;

namespace ImpressaoDeTriangulos
{
    class Program
    {
        /*
            5.15 (Programa para impressão de triângulos) Escreva um aplicativo que exibe 
            os seguintes padrões separadamente, um embaixo do outro.  Utilize loops for 
            para gerar os padrões. Todos os asteriscos (*) devem ser impressos por uma 
            única instrução na forma System.out.  print('*'); o que faz com que os asteriscos 
            sejam impressos lado a lado. Uma instrução na forma System.out.println(); 
            pode  ser utilizada para mover-se para a próxima linha. Uma instrução na forma 
            System.out.print(''); pode ser utilizada para exibir  um espaço para os últimos 
            dois padrões. Não deve haver outras instruções de saída no programa. 
            [Dica: os dois últimos padrões requerem  que cada linha inicie com um número 
            adequado de espaços em branco.] 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 154). Edição do Kindle. 
            Autor: Pedro Filho, 23/04/2021
        */
        static void Main(string[] args)
        {
            Clear(); // limpa a tela

            // primeiro triangulo
            WriteLine( "[A]" ); // imprima
            for( int linha = 1; linha <= 10; linha++ )
            {
                for( int coluna = 1; coluna <= linha; coluna++ )
                {
                    Write("* " );
                } //  fim coluna
                // pula uma linha
                WriteLine();
            } // fim linha

            WriteLine();
            
            // segundo triangulo
            WriteLine( "[B]" ); // imprima
            for( int linha = 1; linha <= 10; linha++ )
            {
                for( int coluna = linha; coluna <= 10; coluna++ )
                {
                    // imprima
                    Write("* " );
                } //  fim coluna
                // pula linha
                WriteLine();
            } // fim linha
            
            WriteLine(); // pula linha

            // terceiro triangulo
            WriteLine( "[C]" ); // imprima
            for( int linha = 1; linha <= 10; linha++ )
            {
                 for( int vazio = linha; vazio <= 10; vazio++ )
                {
                    Write("  " );
                }         
                for( int coluna = 1; coluna <= linha; coluna++ )
                {
                    // imprima
                    Write( "* " );
                } //  fim coluna

                // pula linha
                WriteLine();

            } // fim linha
                        
            WriteLine(); // pula linha

            // terceiro triangulo
            WriteLine( "[D]" ); // imprima
            for( int linha = 1; linha <= 10; linha++ )
            {       
                for( int vazio = 1; vazio <= linha; vazio++ )
                {
                    // imprima
                    Write( "  " );
                } //  fim coluna
                for( int coluna = linha; coluna <= 10; coluna++ )
                {
                    Write("* " );
                }  

                // pula linha
                WriteLine();

            } // fim linha

        } // fim main
    } // fim da classe
} // fim namespace
