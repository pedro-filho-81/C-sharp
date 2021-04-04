using System;

/*3.12 (Classe Invoice) Crie uma classe chamada Invoice para que uma loja de 
    suprimentos de informática a utilize para representar uma  fatura de um item 
    vendido nela. Uma Invoice (fatura) deve incluir quatro partes das informações 
    como variáveis de instância — o  número (tipo String), a descrição (tipo String), 
    a quantidade comprada de um item (tipo int) e o preço por item (double). Sua  
    classe deve ter um construtor que inicializa as quatro variáveis de instância. 
    Forneça um método set e um get para cada variável de instância. Além disso, 
    forneça um método chamado getInvoiceAmount que calcula o valor de fatura 
    (isto é, multiplica a quantidade pelo  preço por item) e depois retorna esse 
    valor como double. Se a quantidade não for positiva, ela deve ser configurada 
    como 0. Se o preço  por item não for positivo, ele deve ser configurado como 0.0. 
    Escreva um aplicativo de teste chamado InvoiceTest que demonstra as  capacidades 
    da classe Invoice. 
    Deitel, Paul; Deitel, Harvey. Java: como programar (p. 77). Edição do Kindle. 
    Autor: Pedro Filho, 04/04/2021.
*/
namespace Vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria o objeto da classe fatura
            Fatura notaFiscal = new Fatura("123456", "HD", 3, 105.35M );

            // COR DO FUNDO AZUL
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            // Cor das letras branca
            Console.ForegroundColor = ConsoleColor.White;
            // cabeçalho
            System.Console.WriteLine("DESCRIÇÃO DA FATURA");
            // limpa as cores
            Console.ResetColor();
            
            // mostra o modêlo de nota fiscal
            System.Console.WriteLine($"NF inicial [{notaFiscal.NumeroDaFatura}] produto [{notaFiscal.Descricao}] " +
                $"Quantidade [{notaFiscal.Quantidade}] preço [{notaFiscal.Preco:C}]" );

            // mostra o valor da fatura
            System.Console.WriteLine($"Valor total: {notaFiscal.ValorDaFatura():C}");

            Console.ReadKey(); // pausa o programa
            Console.Clear(); // limpa a tela

        } // fim main
    } // fim classe
} // fim namespace
