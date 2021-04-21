using System;

namespace ApoliceDeSeguroAuto
{
    class Program
    {
        /*
            // Figura 5.11: AutoPolicy.java  2// Classe que representa uma 
            apólice de seguro de automóvel. 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 135). Edição do Kindle. 
            Pedro Filho,20/04/2021
        */
        static void Main(string[] args)
        {
            // LIMPA A TELA
            Console.Clear();
            // cria um objeto
            ApoliceDeAutomovel apolice1 = new ApoliceDeAutomovel(11111, "Volvo", "BA" );
            ApoliceDeAutomovel apolice2 = new ApoliceDeAutomovel(22222, "Ford EcoSport", "MG" );

            // cabeçalho
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("APÓLICE DE SEGURO DE CARRO");
            Console.ResetColor();

            // MOSTRA O RESULTADO
            Console.WriteLine($"Apólice {apolice1.NumeroDaConta} " +
                $"modelo {apolice1.ModeloDoCarro} " + 
                $"Estado {apolice1.EstadoOndeFica}.");
            
            Console.WriteLine($"Apólice {apolice2.NumeroDaConta} " +
                $"modelo {apolice2.ModeloDoCarro} " + 
                $"Estado {apolice2.EstadoOndeFica}.");
        }
    }
}
