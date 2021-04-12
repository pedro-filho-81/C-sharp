using System;

namespace LimiteDeCredito
{
    class Program
    {
        /*  
            4.18 (Calculador de limite de crédito) Desenvolva um aplicativo Java que determina 
            se um cliente de uma loja de departamentos excedeu o  limite de crédito em uma 
            conta-corrente. Para cada cliente, os seguintes dados estão disponíveis:  
            a) Número de conta.  
            b) Saldo no início do mês.  
            c) Total de todos os itens cobrados desse cliente no mês.  
            d) Total de créditos aplicados ao cliente no mês.  
            e) Limite de crédito autorizado.  
            O programa deve inserir todos esses dados como inteiros, calcular o novo saldo 
            (= saldo inicial + despesas – créditos), exibir o novo saldo e  determinar se 
            o novo saldo excede ao limite de crédito do cliente. Para aqueles clientes cujo 
            limite de crédito foi excedido, o programa deve  exibir a mensagem 
            "Limite de crédito excedido". 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 114). Edição do Kindle. 
            Autor: Pedro Filho, 12/04/2021.
        */
        static void Main(string[] args)
        {
            // cria variáveis
            int numeroDaConta = 0;
            int saldoInicial = 0;
            int comparasAnteriores = 0;
            int comprasAtuais = 0;
            int limiteDeCredito = 0;
            int sentinela = 1;

            // enquanto sentinela diferente de -1 faça
            while( sentinela != -1 )
            {
                // cabeçalho
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("CALCULADORA: LIMITE DE CRÉDITO ");
                Console.ResetColor();

                // entrada de dados
                Console.Write("Digite o número da conta: ");
                // aguarda entrada do usuário
                numeroDaConta = int.Parse(Console.ReadLine());

                // entrada de dados
                Console.Write("Você ainda tem de crédito R$");
                // entrada do usuário
                saldoInicial = int.Parse(Console.ReadLine());

                Console.Write("Valor das compras anteriores R$");
                comparasAnteriores = int.Parse(Console.ReadLine());

                Console.Write("Valor das comparas atuais R$");
                comprasAtuais = int.Parse(Console.ReadLine());

                Console.Write("Limite do cartão de crédito R$");
                limiteDeCredito = int.Parse(Console.ReadLine());
                             
                // cálculo saldo atual
                int totalDasCompras = comparasAnteriores + comprasAtuais;
                int saldoAtual =  totalDasCompras - limiteDeCredito;

                // mostra saldo atual
                Console.WriteLine($"Seu limite é de R${limiteDeCredito} valor das compras R${totalDasCompras}");

                // condição
                // se limite do cartão menor que total das compras
                if( limiteDeCredito < totalDasCompras)
                {
                    // imprima
                    System.Console.WriteLine($"Limite de credito excedido em R${totalDasCompras - limiteDeCredito}");
                } // fim if
                else{ // se não
                    // imprima
                    System.Console.WriteLine($"Você ainda tem de crédito R${limiteDeCredito - totalDasCompras}");
                } // fim else

                // pergunta
                Console.Write("Deseja fazer novo cálculo? [ 1=sim / -1=não ]");
                sentinela = int.Parse(Console.ReadLine());

                Console.Clear();

            } // FIM WHILE

        }// fim main
    } // fim classe
} // fim namespace
