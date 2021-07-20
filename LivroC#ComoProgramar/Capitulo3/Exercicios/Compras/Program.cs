using System;
using static System.Console;

namespace Compras
{
    class Program
    {
        /*
            3.15 (Compras) Escreva um aplicativo que peça ao comprador para inserir
            o preço de três itens, calcule um desconto de 10% aplicável sobre os itens 
            e exiba o valor líquido a pagar. Use as técnicas mostradas na Fig. 3.14.
        */
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria variáveis
            decimal valorProduto1 = 0.0m;
            decimal valorProduto2 = 0.0m;
            decimal valorProduto3 = 0.0m;

            // entrada de dados
            Write("Digite o primeiro valor: ");
            valorProduto1 = decimal.Parse(ReadLine());
            Write("Digite o segundo valor: ");
            valorProduto2 = decimal.Parse(ReadLine());
            Write("Digite o terceiro valor: ");
            valorProduto3 = decimal.Parse(ReadLine());
 
            // calculando os 10% de descontos
            decimal desconto1 = valorProduto1 * 10 / 100;
            WriteLine($"\nO produto 1, de valor {valorProduto1:c}\nTeve um desconto de {desconto1:c}" +
                        $"\nvalor a pagar {valorProduto1 - desconto1:c}");
            
            decimal desconto2 = valorProduto2 * 10 / 100;
            WriteLine($"\nO produto 2, de valor {valorProduto2:c}\nTeve um desconto de {desconto2:c}" +
                        $"\nvalor a pagar {valorProduto2 - desconto2:c}");
            
            decimal desconto3 = valorProduto3 * 10 / 100;
            WriteLine($"\nO produto 3, de valor {valorProduto3:c}\nTeve um desconto de {desconto3:c}" +
                        $"\nvalor a pagar {valorProduto3 - desconto3:c}\n");

        }
    }
}
