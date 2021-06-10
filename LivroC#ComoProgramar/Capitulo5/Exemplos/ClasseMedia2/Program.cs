using System;
using static System.Console;

namespace ClasseMedia2
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria variáveis
            int total = 0; // soma as notas
            int contaNotas = 0; // conta as notas cadastradas
            int nota; // entrada das notas

            // cabeçalho
            WriteLine("LISTA DAS NOTAS LANÇADAS");
            
            // entrada de dados
            Write("Entre com uma nota ou -1 para sair " );
            nota = int.Parse(ReadLine());

            // enquanto nota diferente de -1 faça
            while( nota != -1 )
            {
                // soma as notas
                total += nota;
                // conta as notas informadas
                contaNotas += 1;
                    
                // entrada de dados
                Write("Entre com uma nota ou -1 para sair " );
                nota = int.Parse(ReadLine());
            } // fim while

            if( contaNotas != 0 )
            {
                // calcular a média das notas
                double media = (double) total / contaNotas;

                // mostra resultado
                WriteLine( $"\nTotal das {contaNotas} notas é {total} ");
                WriteLine( $"Média da classe {media:F}");
            } // fim if
            else
            {
                WriteLine("Não houve lançamento de notas." );
            } // fim else
        } // fim main
    } // fim classe
} // fim namespace
