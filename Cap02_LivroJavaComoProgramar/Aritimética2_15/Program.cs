using System;

namespace Aritimética2_15
{
    class Program
    {
        static void Main(string[] args)
        {
            // variáveis
            int num1, num2, soma, subtracao, multiplicacao, divisao;
            int resto;

            // cabeçalho
            // CRIA LETRA BRANCAS
            Console.ForegroundColor = ConsoleColor.White;
            // fundo azul
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            // imprime
            Console.WriteLine("\tARITIMÉTICA");
            // limpa cores
            Console.ResetColor();

            // entrada de dados
            Console.Write("Primeiro número: ");
            int.TryParse(Console.ReadLine(), out num1);
            Console.Write("Segundo número: ");
            int.TryParse(Console.ReadLine(), out num2);

            // cálculos
            soma = num1 + num2;
            subtracao = num1 - num2;
            multiplicacao = num1 * num2;
            divisao = num1 / num2;
            resto = num1 % num2;

            // cabeçalho resultado
            Console.ForegroundColor = ConsoleColor.Black; // cor das letras
            Console.BackgroundColor = ConsoleColor.DarkYellow; // cor do fundo
            Console.WriteLine("\tRESULTADO");
            Console.ResetColor(); // limpa a cor

            // mostra o resultado
            Console.WriteLine($"Soma: {num1} + {num2} = {soma}");
            Console.WriteLine($"Subtração: {num1} - {num2} = {subtracao}");
            Console.WriteLine($"Multiplicação: {num1} * {num2} = {multiplicacao}");
            Console.WriteLine($"divisão: {num1} / {num2} = {divisao}");
            Console.WriteLine($"Resto: {num1} % {num2} = {resto}");

            Console.ReadKey(); // pausa o programa
        }
    }
}
