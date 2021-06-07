using System;
using static System.Console;

namespace classeFatura
{
    class Program
    {
        /*
            3.12 (Classe Invoice) Crie uma classe chamada Invoice para que uma loja de 
            suprimentos de informática a utilize para representar uma  fatura de um item 
            vendido nela. Uma Invoice (fatura) deve incluir quatro partes das informações 
            como variáveis de instância — o  número (tipo String), a descrição (tipo String), 
            a quantidade comprada de um item (tipo int) e o preço por item (double). Sua  
            classe deve ter um construtor que inicializa as quatro variáveis de instância. 
            Forneça um método set e um get para cada variável de instância. Além disso, 
            forneça um método chamado getInvoiceAmount que calcula o valor de fatura 
            (isto é, multiplica a quantidade pelo  preço por item) e depois retorna esse 
            valor como double. Se a quantidade não for positiva, ela deve ser configurada como 0. 
            Se o preço  por item não for positivo, ele deve ser configurado como 0.0. 
            Escreva um aplicativo de teste chamado InvoiceTest que demonstra as  capacidades da classe Invoice. 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 77). Edição do Kindle. 
            Autor: Pedro Filho, 05/04/2021
        */
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cabeçalho
            WriteLine("SUPRIMENTO DE INFORMÁTICA." );

            // variáveis
            int quantidade = 3; // quantidade do produto
            decimal valorDoProduto = 1000m; // valor do produto
            decimal totalDasVendas = 0.0m; // recebe o método que calcular preço

            // cria o objeto da classe Fatura
            Fatura minhaFatura = new Fatura( "001", "Computador", quantidade, valorDoProduto );

            // calcular o preço
            totalDasVendas = minhaFatura.CalcularPreço(quantidade, valorDoProduto );

            // mostra fatura
            WriteLine($"Fatura nº {minhaFatura.numero}\nProduto: {minhaFatura.descricao}" +
                    $"\nQuantidade: {quantidade}\nValor: {minhaFatura.Preco:C}" +
                    $"\nTotal a pagar: {totalDasVendas:C}");

            Console.WriteLine("\nHello World C#!");
        } // fim main
    } // fim classe
} // fim namespace
