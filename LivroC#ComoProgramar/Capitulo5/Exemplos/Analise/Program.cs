using System;
using static System.Console;

namespace Analise
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria variáveis
            int passou = 0;
            int perdeu = 0;
            int contaEstudantes = 1;

            // enquanto conta estudantes menor ou igual a 10
            while( contaEstudantes <= 10 )
            {
                // entrada de dados
                Write("Entre com o resultado (1 = passou, 2 = perdeu) ");
                // recebe resposta do usuário
                int resultado = int.Parse(ReadLine());

                // se resultado igual a 1
                if( resultado == 1 )
                {
                    // passou recebe 1
                    passou += 1;
                } // fim if
                // se não
                else
                {
                    // perdeu recebe 1
                    perdeu += 1;
                } // fim else
                
                // soma 1 ao conta estudantes
                contaEstudantes += 1;

            }  // fim while

            // mostra o resultado
            WriteLine($"\nPassaram {passou}\nPerderam {perdeu}");

            // se passou maior que 8
            if( passou > 8 )
            {
                WriteLine("Bônus para o professor.");
            } // fim if
            
        } // fim main
    } // fim classe
} // fim namespace
