using System;
/*
 * 2.17 (Aritmética, menor e maior) Escreva um aplicativo que insira três inteiros 
 * digitados pelo usuário e exiba a soma, média, produto e os  números menores e 
 * maiores. Utilize as técnicas mostradas na Figura 2.15. [Observação: o cálculo da 
 * média neste exercício deve resultar  em uma representação de inteiro. Assim, se a 
 * soma dos valores for 7, a média deverá ser 2, não 2,3333...] 
        Deitel, Paul; Deitel, Harvey. Java: como programar (p. 52). Edição do Kindle. 
    Autor: Pedro Filho, 25/03/2021
 */

namespace AritimeticaMaiorMenor2_17
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria variáveis
            int num1, num2, num3;
            int soma, produto;
            float media;
            int maior, menor;

            // cabeçalho das questões
            Console.ForegroundColor = ConsoleColor.White; // muda a cor da letra
            Console.BackgroundColor = ConsoleColor.DarkBlue; // muda a cor do fundo
            Console.WriteLine("ARITIMÉTICA MAIOR MENOR VALOR");
            Console.ResetColor(); // limpa as cores

            // entrada de dados
            Console.Write("Primeiro número: ");
            int.TryParse(Console.ReadLine(), out num1);
            
            Console.Write("Segundo número: ");
            int.TryParse(Console.ReadLine(), out num2);
            
            Console.Write("Terceiro número: ");
            int.TryParse(Console.ReadLine(), out num3);

            // calculando
            soma = num1 + num2 + num3;
            media = (float)soma / 3;
            produto = num1 * num2 * num3;

            // atribuindo valor
            maior = num1;
            menor = num1;

            // verificando o maior valor
            if(num2 > maior)
            {
                maior = num2;
            }
            if( num3 > maior)
            {
                maior = num3;
            }
            
            // verificando o menor valor
            if( num2 < menor)
            {
                menor = num2;
            }
            if(num3 < menor)
            {
                menor = num3;
            }

            // cabeçalho das questões
            Console.ForegroundColor = ConsoleColor.Black; // muda a cor da letra
            Console.BackgroundColor = ConsoleColor.DarkYellow; // muda a cor do fundo
            Console.WriteLine("ARITIMÉTICA MAIOR MENOR VALOR");
            Console.ResetColor(); // limpa as cores

            // mostra resultado
            Console.WriteLine($"Soma: {num1} + {num2} + {num3} = {soma}");
            Console.WriteLine($"Média: {soma} / 3 = {media:N}");
            Console.WriteLine($"Produto: {num1} * {num2} * {num3} = {produto}");

            // mostrando o maior valor
            Console.WriteLine($"O maior valor é {maior}");
            Console.WriteLine($"O menor valor é {menor}");


            //
        }
    }
}
