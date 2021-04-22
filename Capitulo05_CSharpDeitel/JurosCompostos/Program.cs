using System;
using static System.Console;

namespace JurosCompostos
{
    class Program
    {
        /*
            5.14 (Programa de juros compostos modificado) Modifique o aplicativo de juros 
            compostos da Figura 5.6 para repetir os passos para taxas  de juros de 5%, 6%, 
            7%, 8%, 9% e 10%. Utilize um loop for para variar a taxa de juros. 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 154). Edição do Kindle. 
            Autor: Pedro Filho, 22/04/2021
        */
        static void Main(string[] args)
        {
            // cria variáveis
            decimal valorInicial = 0;
            decimal valorFinal = 0;
            float taxa = 0f;
            int tempoAplicado = 0;
            decimal jurosRecebido = 0;
            int i = 0;
            int sentinela = 0;
            

            // limpa a tela
            Console.Clear();

            // cabeçalho
            WriteLine("CALCULANDO JUROS COMPOSTOS" );

            // Entrada de dados
            Console.Write("Informe o valor inicial R$" );
            valorInicial = decimal.Parse(Console.ReadLine());

            Write("Informe a taxa de juros: " );
            taxa = float.Parse(ReadLine());

            Write("Informe o tempo da aplicação: " );
            tempoAplicado = int.Parse(ReadLine());

            // calcular
            taxa /= 100;
            valorFinal = valorInicial * (decimal) Math.Pow( 1.0 + taxa, tempoAplicado );
            jurosRecebido = valorFinal - valorInicial;
            
            System.Console.WriteLine(); // pula linha

            // mostra resultado
            WriteLine($"Valor aplicado {valorInicial:C}" );
            WriteLine($"Taxa = {taxa:f2}%" );
            WriteLine($"Juros recebido = {jurosRecebido:C}" );
            WriteLine($"Valor Final {valorFinal:C}");

            // AQUI ESTÁ COMO O EXERCÍCIO SOLICITA
            // CABEÇALHO
            WriteLine("CALCULANDO JUROS COMPOSTO COM TAXA VARIÁVEL" );

            // loop para a taxa de juros
            for( i = 5; i <= 10; i++ )
            {
                // TAXA RECEBE O VALOR DE VENDAS
                taxa = i;

                // calcular
                taxa /= 100;
                valorFinal = valorInicial * (decimal) Math.Pow( 1.0 + taxa, tempoAplicado );
                jurosRecebido = valorFinal - valorInicial;
                                
                System.Console.WriteLine(); // pula linha

                // mostra resultado
                WriteLine($"Valor aplicado {valorInicial:C}" );
                WriteLine($"Taxa = {taxa:f2}%" );
                WriteLine($"Juros recebido = {jurosRecebido:C}" );
                WriteLine($"Valor Final {valorFinal:C}");

                ReadKey(); // pausa o programa

            } // FIM FOR
        } // FIM MAIN
    } // FIM CLASSE
} // FIM NAMESPACE
