using System;

namespace Aritimetica2_15
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria variáveis
            int num1, num2, quociente;
            int soma, produto, diferenca, cociente;

            // cor da letra branca
            Console.ForegroundColor = ConsoleColor.White;
            // cor do fundo azul
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            // cabeçalho
            Console.WriteLine("\tARITIMÉTICA");
            // valta ao normal
            Console.ResetColor();

            // entrada de dados
            Console.Write("Primeiro número: ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out num1);

            Console.Write("Segundo número: ");
            int.TryParse(Console.ReadLine(), out num2);

            // calcular
            soma = num1 + num2;
            produto = num1 * num2;
            diferenca = num1 - num2;
            quociente = num1 / num2;

            // impmir resultado
            Console.WriteLine($"A soma de {num1} + {num2} = {soma}");
            Console.WriteLine($"A diferença de {num1} - {num2} = {diferenca}");
            Console.WriteLine($"O produto de {num1} * {num2} = {produto}");
            Console.WriteLine($"A soma de {num1} / {num2} = {soma}");

            Console.ReadKey(); // pausa o programa

            Console.WriteLine("Hello World!");
        }
    }
}
