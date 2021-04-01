using System;

namespace ParOuImpar2_25
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria uma variável
            int num;


            // cabeçalho
            Console.ForegroundColor = ConsoleColor.White; // letras brancas
            Console.BackgroundColor = ConsoleColor.DarkBlue; // fundo azul
            Console.WriteLine("VEJA SE O NÚMERO É PAR OU ÍMPAR");
            Console.ResetColor();

            // entrada de dados
            Console.Write("Digite um número: ");
            int.TryParse(Console.ReadLine(), out num);

            // cabeçalho resultado
            Console.ForegroundColor = ConsoleColor.Green; // letras brancas
            Console.BackgroundColor = ConsoleColor.Yellow; // fundo azul
            
            // verificar se o número é par ou impar
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} é par.");
            }
            else
            {
                Console.WriteLine($"{num} é ímpar.");
            }

            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
