using System;

namespace QuadradoDeAsterisco
{
    class Program
    {
        /*
            4.29 (Quadrado de asteriscos) Escreva um aplicativo que solicita ao usuário 
            que insira o tamanho do lado de um quadrado e, então, exibe um  quadrado vazio 
            desse tamanho com asteriscos. Seu programa deve trabalhar com quadrados de todos 
            os comprimentos de lado possíveis  entre 1 e 20. 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 117). Edição do Kindle.
            Autor Pedro Filho, 14/04/2021 
        */
        static void Main(string[] args)
        {
            // cria variáveis
            int linha = 0;
            int coluna = 0;
            int vazio = 0;
            int num = 20;

            // entrada de dados
            System.Console.Write("Informe o tamanho do quadrado: ");
            num = int.Parse(Console.ReadLine());

            // linha superior
            while( linha < num )
            {
                System.Console.Write("*");
                linha++;
            } // fim da linha

            // pula linha
            System.Console.WriteLine();
            
            // enquanto coluna menor que num menos 2 faça
            while( coluna < num - 2 )
            {
                // imprime o asterisco da coluna
                System.Console.Write("*");

                // enquanto vazio menor que num menos 2 faça
                while( vazio < num - 2 )
                {
                    // imprima espaços vazior
                    System.Console.Write(" ");
                    // incremente o vazio em 1
                    vazio++;
                } // fim while vazio
                
                // incremente a coluna em 1
                coluna++;
                vazio = 0; // zera o vazio
                // imprima
                System.Console.Write("*");
                // imprima
                System.Console.WriteLine();
            
            } // fim while coluna

            linha = 0; // zerando a linha
            
            // linha inferior
            while( linha < num )
            {
                // imprima o asterisco
                System.Console.Write("*");
                linha++; // incremente a linha em 1
            } // fim da última linha

        } // fim main
    } // fim da classe
} // vim nomespace
