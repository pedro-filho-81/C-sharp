using System;
/*
 * 2.24 (Inteiros maiores e menores) Escreva um aplicativo que leia cinco inteiros,
 * além de determinar e imprimir o maior e o menor inteiro  no grupo. Utilize 
 * somente as técnicas de programação que você aprendeu neste capítulo. 
    Deitel, Paul; Deitel, Harvey. Java: como programar (p. 53). Edição do Kindle. 
    Autor: Pedro Filho, 25/03/2021
 */

namespace InteirosMaioresMenores2_24
{
    class Program
    {
        static void Main(string[] args)
        {
            // variáveis
            int n1, n2, n3, n4, n5;
            int maior, menor;

            // entrada de dados
            Console.Write("Primeiro número: ");
            int.TryParse(Console.ReadLine(), out n1);
            Console.Write("Segundo número: ");
            int.TryParse(Console.ReadLine(), out n2);
            Console.Write("Terceiro número: ");
            int.TryParse(Console.ReadLine(), out n3);
            Console.Write("Quarto número: ");
            int.TryParse(Console.ReadLine(), out n4);
            Console.Write("Quinto número: ");
            int.TryParse(Console.ReadLine(), out n5);

            // atribuindo valores a maior e menor
            maior = n1;
            menor = n1;

            // condições para achar o maior valor
            if(maior < n2)
            {
                maior = n2;
            }
            if (maior < n3)
            {
                maior = n3;
            }
            if (maior < n4)
            {
                maior = n4;
            }
            if (maior < n5)
            {
                maior = n5;
            }

            // encontrando o menor valor
            if(menor > n2)
            {
                menor = n2;
            }
            if (menor > n3)
            {
                menor = n3;
            }
            if (menor > n4)
            {
                menor = n4;
            }
            if (menor > n5)
            {
                menor = n5;
            }

            // mostra resultado
            Console.WriteLine($"O maior valor é {maior}");
            Console.WriteLine($"O menor valor é {menor}");
            Console.ReadKey(); // pausa o programa
        }
    }
}
