using System;
using static System.Console;

namespace LimiteDeCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // variáveis
            decimal resultadoJuros;

            // cria o objeto da classe Credito
            Credito investimento = new Credito( 100, 500, 5, 4 );

            resultadoJuros = investimento.Juros( 500, 5, 4 );

            // chama o método MostraResultado
            MostraResultado( investimento, resultadoJuros );

            Console.WriteLine("Hello World!");
        } // fim main

        // cria método MostraResultado
        static void MostraResultado(Credito meuInvestimento, decimal jurosGanhos )
        {
            // cabeçalho
            WriteLine("INVESTIMENTO\t\tDADOS" );

            // MOSTRA resultado
            WriteLine($"Número da conta:\t{meuInvestimento.numeroDaConta}" +
                        $"\nValor investido:\t{meuInvestimento.ValorInvestido}" +
                        $"\nTaxa de juros:\t\t{meuInvestimento.TaxaDeJuros}%" +
                        $"\nTempo investido:\t{meuInvestimento.TempoAplicado} mêses" +
                        $"\nJuros ganhos:\t\t{jurosGanhos:C}");
        } // fim método

    } // fim classe
} // fim name
