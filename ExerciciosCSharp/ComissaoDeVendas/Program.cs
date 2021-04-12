using System;

namespace ComissaoDeVendas
{
    class Program
    {
        /*
            4.19 (Calculador de comissão de vendas) Uma grande empresa paga seu pessoal 
            de vendas com base em comissões. O pessoal de vendas  recebe R$ 200 por semana 
            mais 9% de suas vendas brutas durante esse período. Por exemplo, um vendedor 
            que realiza um total de vendas de mercadorias de R$ 5.000 em uma semana recebe 
            R$ 200 mais 9% de R$ 5.000, um total de R$ 650. Foi-lhe fornecida uma lista dos 
            itens  vendidos por cada vendedor. Os valores desses itens são como segue:  
            Item  Value  
            1     239.99  
            2     129.75  
            3      99.95  
            4     350.89  
            Desenvolva um aplicativo que recebe entrada de itens vendidos por um vendedor 
            durante a última semana e calcula e exibe os rendimentos do vendedor. Não existe 
            nenhum limite para o número de itens que pode ser vendido. 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 115). Edição do Kindle. 
            Autor: Pedro Filho, 12/04/2021
        */
        static void Main(string[] args)
        {
            // cria constantes
            const int pagamentoPorSemana = 200;
            const decimal produto1 = 239.99m;
            const decimal produto2 = 129.75m;
            const decimal produto3 = 99.95m;
            const decimal produto4 = 350.89m;
            const decimal produto5 = 525.89m;

            // variáveis
            int comissaoPorVendas = 0;
            int valorDaVendasSemanais = 0;
            int sentinela = 1;
            decimal qtdProduto1 = 0;
            decimal qtdProduto2 = 0;
            decimal qtdProduto3 = 0;
            decimal qtdProduto4 = 0;
            decimal qtdProduto5 = 0;

            // enquanto sentinela diferente de -1 faça
            while( sentinela != -1 )
            {
                // cabeçalho
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("ITENS DA COMISSÃO DE VENDAS");
                Console.ResetColor();

                // menu de produtos da loja
                System.Console.WriteLine($"\tItem{"Valor",10}");
                System.Console.WriteLine($"\t1{"239,99", 14}");
                System.Console.WriteLine($"\t2{"129,75", 14}");
                System.Console.WriteLine($"\t3{" 99,95", 14}");
                System.Console.WriteLine($"\t4{"350,89", 14}");
                System.Console.WriteLine($"\t5{"525,89", 14}");
                
                // cabeçalho
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("ENTRADA DE DADOS DA COMISSÃO DE VENDAS");
                Console.ResetColor();

                // ENTRADA DE DADOS
                System.Console.Write("Item 1 quantos produtos vendeu? ");
                // entrada do usuário
                qtdProduto1 = int.Parse(Console.ReadLine());
                // cálculo da venda do produto 1
                decimal totalProduto1 = produto1 * qtdProduto1;

                System.Console.Write("Item 2 quantos produtos vendeu? ");
                // entrada do usuário
                qtdProduto2 = int.Parse(Console.ReadLine());
                // cálculo da venda do produto 1
                decimal totalProduto2 = produto2 * qtdProduto2;

                System.Console.Write("Item 3 quantos produtos vendeu? ");
                // entrada do usuário
                qtdProduto3 = int.Parse(Console.ReadLine());
                // cálculo da venda do produto 1
                decimal totalProduto3 = produto3 * qtdProduto3;

                System.Console.Write("Item 4 quantos produtos vendeu? ");
                // entrada do usuário
                qtdProduto4 = int.Parse(Console.ReadLine());
                // cálculo da venda do produto 1
                decimal totalProduto4 = produto4 * qtdProduto4;

                System.Console.Write("Item 5 quantos produtos vendeu? ");
                // entrada do usuário
                qtdProduto5 = int.Parse(Console.ReadLine());
                // cálculo da venda do produto 1
                decimal totalProduto5 = produto5 * qtdProduto5;               
                
                // cabeçalho
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("RELATÓRIO COMISSÃO DE VENDAS");
                Console.ResetColor();

                // mostra relatório
                System.Console.WriteLine($"Produto1 vendeu {qtdProduto1} total {totalProduto1:C2}");
                System.Console.WriteLine($"Produto2 vendeu {qtdProduto2} total {totalProduto2:C2}");
                System.Console.WriteLine($"Produto3 vendeu {qtdProduto3} total {totalProduto3:C2}");
                System.Console.WriteLine($"Produto4 vendeu {qtdProduto4} total {totalProduto4:C2}");
                System.Console.WriteLine($"Produto5 vendeu {qtdProduto5} total {totalProduto5:C2}");
                // final
                Console.Write( "Deseja fazer novo cálculo? [ 1=sim / -1=não ]" );
                sentinela = int.Parse(Console.ReadLine());
                
            } // fim while
        
                Console.Clear(); // limpa a tela

        } // fim main
    } // fim classe
} // fim namespace
