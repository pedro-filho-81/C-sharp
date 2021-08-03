using System;
using static System.Console;

namespace CalculandoNivelDoEstoque
{
    class Program
    {
        /*
            5.18 (Calculadora de nível de estoque) Desenvolva um aplicativo C # que irá 
            determinar se o nível de qualquer um dos itens no estoque de uma loja caiu 
            abaixo de 1% do número inicial de unidades. Para cada item de estoque, 
            os seguintes fatos estão disponíveis:
            a) o código do item
            b) o número inicial de unidades
            c) o número de unidades adquiridas
            d) o número de unidades emitidas
            O aplicativo deve inserir todos esses fatos como inteiros, calcular 
            o número de fechamento de unidades (= número de abertura de unidades 
            + número de unidades compradas - número de unidades emitidas), exibir 
            o número de unidades de fechamento e determinar se o número de unidades 
            de fechamento caiu abaixo do limite inferior. Para os itens cuja 
            quantidade caiu abaixo do limite inferior, o aplicativo deve exibir 
            a mensagem “Adquira mais unidades imediatamente”.
            Use a iteração controlada por sentinela para obter os dados de cada item.
            Autor: Pedro Filho, 02/08/2021
        */
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();
            
            // variáveis
            int codigoDoProduto;
            int quantidadeNoEstoque;
            int quantidadeComprada;
            int quantidadeVendida;
            int saldoDoEstoque = 0;
            int alertaDoEstoque = 0;
            int quantidadeDeAlerta = 0;

            // entrada de dados
            Write("Digite o código do item (-1 = Sair): ");
            codigoDoProduto = int.Parse(ReadLine());

            // enquando código do item diferente de -1
            while (codigoDoProduto != -1 )
            {
                Write("Digite a quantidade no estoque: " );
                quantidadeNoEstoque = int.Parse(ReadLine());

                Write("Digite a quantidade comprada: ");
                quantidadeComprada = int.Parse(ReadLine());

                Write("Digite a quantidade vendida: ");
                quantidadeVendida = int.Parse(ReadLine());

                // calcular
                saldoDoEstoque = (quantidadeNoEstoque + quantidadeComprada ) - quantidadeVendida;
                quantidadeDeAlerta = ( saldoDoEstoque * 100 ) / quantidadeNoEstoque;
                
                // mostrando resultado
                WriteLine($"\nO produto {codigoDoProduto}" +
                            $"\nEstoque inicial [{quantidadeNoEstoque}]" +
                            $"\nQuantidade comprada {quantidadeComprada}\nQuantidade vendida {quantidadeVendida}" +
                            $"\nResta no estoque [{saldoDoEstoque}]" + 
                            $"\nQuantidade de alerta {quantidadeDeAlerta}%");

                // entrada de dados
                Write("\nDigite o código do item (-1 = Sair): ");
                codigoDoProduto = int.Parse(ReadLine());
            } // fim while

            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim name
