using System;
using static System.Console;

namespace TaxaDeEstacionamento
{
    class Program
    {
        /*
            6.8 (Taxas de estacionamento) Um estacionamento cobra uma tarifa mínima de 
            R$ 2,00 para estacionar por até três horas. Um adicional  de R$ 0,50 por hora 
            não necessariamente inteira é cobrado após as três primeiras horas. A tarifa 
            máxima para qualquer dado período  de 24 horas é R$ 10,00. Suponha que nenhum 
            carro fique estacionado por mais de 24 horas por vez. Escreva um aplicativo que 
            calcule e  exiba as tarifas de estacionamento para cada cliente que estacionou 
            nessa garagem ontem. Você deve inserir as horas de estacionamento  para cada cliente. 
            O programa deve exibir a cobrança para o cliente atual e calcular e exibir 
            o total dos recibos de ontem. Ele deve utilizar  o método calculateCharges para 
            determinar a tarifa para cada cliente. 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 186). Edição do Kindle. 
            Autor: Pedro Filho, 29/04/2021
        */

        static void Main(string[] args)
        {
            // cria variável
            float tempo = 1;
            decimal resposta = 0M;
            decimal contadorDosValores = 0;
            int totalDeCarrosEstacionados = 0;

            while( tempo > 0 )
            {
                Clear(); // limpa tela

                // cabeçalho
                BackgroundColor = ConsoleColor.DarkBlue;
                ForegroundColor = ConsoleColor.White;
                WriteLine("TAXA DE ESTACIONAMENTO");
                ResetColor();

                // entrada de dados
                Write("Digite o tempo que o carro ficou estacionado [ -1 = sair ]: " );
                tempo = float.Parse(ReadLine());
                
                // se o tempo for maior que zero
                if( tempo > 0 )
                {    
                    // resposta recebe o valor retornado do método 
                    resposta = CalTaxaDeEstacionamento( tempo );
                    contadorDosValores += resposta;
                    totalDeCarrosEstacionados++;
                    
                    // imprime resultado
                    Console.WriteLine($"Por {tempo}h estacionado valor a pagar { resposta:C}");

                } // fim if
                else // se não
                {
                    // saia do programa
                    break;
                } // fim else

            } // fim while
            WriteLine($"{totalDeCarrosEstacionados} carros estacionados." );
            WriteLine($"Total arrecadado {contadorDosValores:C}");
        } // fim main

        public static decimal CalTaxaDeEstacionamento( float tempoEstacionado ) 
        {
            // cria variável
            decimal valorDaTarifa = 0M;
            float tempoExtra = 0.0F;

            // até 3 horas estacionado
            if(tempoEstacionado > 0.0F && tempoEstacionado <= 3.0F )
                // o valor da tarifa é de 
                valorDaTarifa = 2.0M;

            // acima de 3 horas estacionado
            else if( tempoEstacionado > 3.0f && tempoEstacionado < 24.0f )
                // calcular o tempo extra
                tempoExtra = tempoEstacionado - 3.0f;
                // e o valor da tarifa é calculado com o tempo extra
                valorDaTarifa = (decimal) tempoExtra * 0.5M + 2.0M;

            return valorDaTarifa; // retorna o valor da tarifa

        } // fim método
        
    } // fim classe
} // fim namespace
