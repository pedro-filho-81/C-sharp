using System;
using static System.Console;

namespace LimiteDeCredito
{
    class Program
    {
        /*
            5.17 (Juros sobre Depósito a Prazo) Os investidores estão preocupados com os juros 
            que seus investimentos ganham em um mês. Um investidor acompanhou os juros ganhos 
            em vários investimentos, registrando o valor de cada investimento e os juros ganhos 
            em cada um. Desenvolva um aplicativo C # que irá inserir o valor investido e os juros 
            ganhos (ambos como números inteiros) para cada investimento. O aplicativo deve calcular 
            e exibir os juros combinados ganhos para cada investimento até o mês atual. 
            Os resultados são arredondados para o centésimo mais próximo. Use o método ReadLine da 
            classe Console e a iteração controlada por sentinela para obter os dados do usuário.
            Autor: Pedro Filho, 02/08/2021
        */
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // variáveis
            int valorInicial;
            int taxaDeJuros;
            int tempoInvestido;
            int jurosGanhos;

            // entrada de dados
            Write("Digite o valor inicial ( -1 para sair ) R$" );
            valorInicial = int.Parse(ReadLine());

            // enquanto o valor inicial diferente de -1
            while ( valorInicial != -1 )
            {
                Write("Digite a taxa de juros: ");
                taxaDeJuros = int.Parse(ReadLine());

                Write("Informe o tempo da aplicação: " );
                tempoInvestido = int.Parse(ReadLine());

                decimal juros = (decimal) valorInicial * taxaDeJuros * tempoInvestido / 365;

                WriteLine($"Valor inicial R${valorInicial}" +
                            $"\nTaxa de juros {taxaDeJuros}%" +
                            $"\nValor dos juros R${juros:C}");

                // entrada de dados
                Write("\nDigite o valor inicial ( -1 para sair ) R$" );
                valorInicial = int.Parse(ReadLine());

            } // fim while

            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim name
