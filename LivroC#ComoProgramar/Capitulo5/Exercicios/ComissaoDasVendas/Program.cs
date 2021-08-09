using System;
using static System.Console;

namespace ComissaoDasVendas
{
    class Program
    {
        /*
            5.19 (Calculadora de Comissão de Vendas) Uma grande empresa paga seus vendedores 
            com base em comissões. Os vendedores recebem $ 200 por semana mais 9% de suas 
            vendas brutas naquela semana. Por exemplo, um vendedor que vende $ 5.000 em mercadorias 
            por semana recebe $ 200 mais 9% de $ 5.000, ou um total de $ 650. Você recebeu uma lista 
            dos itens vendidos por cada vendedor. Os valores desses itens são os seguintes:
            Valor do item
            1 239,99
            2 129,75
            3 99,95
            4 350,89
            Desenvolva um aplicativo C # que insere os itens vendidos de um vendedor na última semana e, 
            em seguida, calcula e exibe os ganhos desse vendedor. Não há limite para o número de itens 
            que podem ser vendidos por um vendedor.
            Deitel, Harvey; Deitel, Paul. Visual C # How to Program, eBook, Global Edition (p. 226). 
            Pearson Education. Edição do Kindle.
            Pedro Filho, 03/08/2021
        */
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // variáveis
            int vendedor1;
            int vendedor2;
            int vendedor3;
            int vendedor4;
            int contador = 1;
            int linha = 1;
            int coluna = 1;
            int vendas;
            decimal totalDasVendas = 0;
            int quantidade = 0;

            // CABEÇALHO
            WriteLine("COMISSÃO DAS VENDAS");

            // MENU DE OPÇÕES
            WriteLine("*******************");
            WriteLine("ITEM\tVALOR");
            WriteLine("1\tR$239,99");
            WriteLine("2\tR$129,75");
            WriteLine("3\tR$ 99,95");
            WriteLine("4\tR$350,89");
            WriteLine("*******************");

            // entrada de dados
            Write("Digite o codigo do vendedor: ");
            int codigoDoVendedor = int.Parse(ReadLine());

            Write("Digite o produto vendido (1, 2, 3, 4): ");
            int produto = int.Parse(ReadLine());

            Write("Quantos produtos vendeu?");
            int quantidadeVendida = int.Parse(ReadLine());

            switch (produto)
            {
                case 1:
                    quantidade += quantidadeVendida;
                    totalDasVendas =  (decimal) (quantidadeVendida * 239.99m);
                    break;

                case 2:
                    quantidade += quantidadeVendida;
                    totalDasVendas =  (decimal)  (quantidadeVendida * 129.75m);
                    break;

                case 3:
                    quantidade += quantidadeVendida;
                    totalDasVendas =   (decimal) (quantidadeVendida * 99.95m);
                    break;

                case 4:
                    quantidade += quantidadeVendida;
                    totalDasVendas =  (decimal)  (quantidadeVendida * 350.89m);
                    break;

                default:
                    totalDasVendas += 0m;
                    break;
            } // fim  switch

            // calcular a comissão
            decimal comissao = // falta calcular a comissão
            
            // mostra resultado
            WriteLine($"O vendedor {codigoDoVendedor} vendeu {quantidade} produto(s)" +
                        $"\nRecebeu de salário {200 + (totalDasVendas * )}");
            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim name
