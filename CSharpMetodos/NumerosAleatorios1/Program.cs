using System;
using static System.Console;


namespace NumerosAleatorios1
{
    class Program
    {
        /*
            6.12 Escreva instruções que atribuem inteiros aleatórios à variável n nos seguintes intervalos:  
            a) 1 d n d 2.  b) 1 d n d 100.  c) 0 d n d 9.  d) 1000 d n d 1112.  
            e) –1 d n d 1.  f) –3 d n d 11. 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 187). Edição do Kindle. 
            Autor: Pedro Filho, 01/05/2021
        */
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cabeçalho
            BackgroundColor = ConsoleColor.DarkBlue;
            ForegroundColor = ConsoleColor.White;
            WriteLine("NÚMEROS ALEATÓRIOS");
            ResetColor();

             // MOSTRA RESULTADO
            Console.WriteLine($"Imprime número de 1 até 2 |{Aleatorio1()}|");
            Console.WriteLine($"Imprime número entre 1 e 100  |{Aleatorio100()}|");
            Console.WriteLine($"Imprime número entre 0 e 9  |{Aleatorio09()}|");
            Console.WriteLine($"Imprime número entre 1000 e 1112  |{Aleatorio1112()}|");
            Console.WriteLine($"Imprime número entre -1 e 1  |{Aleatorio_1()}|");
            Console.WriteLine($"Imprime número entre -3 e 11  |{Aleatorio311()}|");

        } // fim main

        // cria método
        public static int Aleatorio1()
        {
            // cria objeto aleatório
            Random numero = new Random();
            int aleatorio = numero.Next(1, 3);
            return aleatorio;
        } // fim função

        // cria método
        public static int Aleatorio100()
        {
            // cria objeto aleatório
            Random numero = new Random();
            int aleatorio = numero.Next(1, 101);
            return aleatorio;
        } // fim função

        // cria método
        public static int Aleatorio09()
        {
            // cria objeto aleatório
            Random numero = new Random();
            int aleatorio = numero.Next(0, 10);
            return aleatorio;
        } // fim função

        // cria método
        public static int Aleatorio1112()
        {
            // cria objeto aleatório
            Random numero = new Random();
            int aleatorio = numero.Next(1000, 1113);
            return aleatorio;
        } // fim função
        
        // cria método
        public static int Aleatorio_1()
        {
            // cria objeto aleatório
            Random numero = new Random();
            int aleatorio = numero.Next(-1, 2);
            return aleatorio;
        } // fim função
                
        // cria método
        public static int Aleatorio311()
        {
            // cria objeto aleatório
            Random numero = new Random();
            int aleatorio = numero.Next(-3, 12);
            return aleatorio;

        } // fim função

    } // fim classe
} // fim namespace
