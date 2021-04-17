using System;

namespace JurosCompostos
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria variáveis
            decimal montante = 0m;
            decimal principal = 0M;
            double taxaDeJuros = 0.0;
            int prazoDaAplicacao = 0;
            int tempo = 0;
            int sentinela = 1;

            // fará enquanto sentinela diferente de -1
            while( sentinela != -1 ) 
            {
                Console.Clear(); // limpa a tela
                
                // cabeçalho
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine( "CÁLCULO DE JUROS COMPOSTOS" );
                Console.ResetColor();

                // entrada do principal
                System.Console.Write("Informe o valor principal R$" );
                principal = decimal.Parse(Console.ReadLine());

                // entra do valor da taxa
                System.Console.Write("Informe o valor da taxa: ");
                taxaDeJuros = double.Parse(Console.ReadLine());
                taxaDeJuros /= 100; // cálcula a taxa

                // entrada do prazo da aplicação
                System.Console.Write("Informe o prazo da aplicação: ");
                prazoDaAplicacao = int.Parse(Console.ReadLine());

                // loop para calcular o valor da aplicação
                for( tempo = 0; tempo <= prazoDaAplicacao; tempo++ )
                {
                    // cálculo do montante
                    montante = principal * (decimal) Math.Pow( 1.0 + taxaDeJuros, tempo );
                } // fim for

                // imprime o resultado
                System.Console.WriteLine($"Você aplicou {principal:C2}");
                System.Console.WriteLine($"A uma taxa de {taxaDeJuros:n2}%");                
                System.Console.WriteLine($"Pelo prazo de {tempo - 1}\nRecebeu {montante:C2}");
                System.Console.WriteLine($"Ganhou de juros {montante - principal:c2}");
                System.Console.WriteLine();
                
                // pergunta se quer continuar
                System.Console.Write("Deseja continuar? [ 1 = sim / -1 = não ]");
                // aguarda a resposta
                sentinela = int.Parse(Console.ReadLine());

            } // fim while externo

            Console.Clear(); // limpa a tela ao sair do programa
        } // fim main
    } // fim classe
} // fim namespace
