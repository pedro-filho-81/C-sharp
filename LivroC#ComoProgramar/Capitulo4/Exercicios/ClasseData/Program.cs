using System;
using static System.Console;

namespace ClasseData
{
    class Program
    {
        /*
            3.14 (Classe Date) Crie uma classe chamada Date que inclua três variáveis de 
            instância — mês (tipo int), dia (tipo int) e ano (tipo int).  Forneça um 
            construtor que inicializa as três variáveis de instância supondo que os valores 
            4fornecidos estejam corretos. Ofereça um método  set e um get para cada variável 
            de instância. Apresente um método displayDate que exiba mês, dia e ano separados 
            por barras normais  (/). Escreva um aplicativo de teste chamado DateTest que 
            demonstre as capacidades da classe Date. 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 77). Edição do Kindle. 
            Autor: Pedro Filho, 07/06/2021
        */
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria o objeto da classe data
            // DATA VÁLIDA
            Data minhaData = new Data(12, 02, 2021);
            // DATA INVÁLIDA
            Data minhaData1 = new Data(33, 13, 3000);

            // cabeçalho
            WriteLine( "MOSTRA DATA" );

            // IMPRIME O RESULTADO
            minhaData.MostraData();
            minhaData1.MostraData();
            
            Console.WriteLine("Precione qualquer tecla para terminar.");
            ReadKey(); // pausa o programa
        } // fim main
    } // fim classe
} // fim namespace
