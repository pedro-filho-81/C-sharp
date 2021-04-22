using System;

namespace Fatorial
{
    class Program
    {
        /*
            5.13 (Fatoriais) Fatoriais costumam ser utilizados em problemas de probabilidade. 
            O fatorial de um inteiro positivo n (escrito como n! e pronunciado como “fatorial de n”) 
            é igual ao produto dos números inteiros positivos de 1 a n. Escreva um aplicativo 
            que calcula os fatoriais  de 1 a 20. Utilize o tipo long. Exiba os resultados 
            em formato tabular. Que dificuldade poderia impedir você de calcular o fatorial de 100? 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 154). Edição do Kindle. 
            Autor: Pedro Filho, 22/04/2021
        */
        static void Main(string[] args)
        {
            // cria variáveis
            double num = 0;
            double fatorial = 1;

            Console.Clear(); // limpa a tela
            
            // cabeçalho
            System.Console.WriteLine("IMPRIME O FATORIAL DE UM NÚMERO");
 
            // Entrada de dados
            Console.Write("Digite um número para ver seu fatorial: ");
            num = long.Parse(Console.ReadLine());

            // modele de fatorial
            System.Console.Write($"{num}! = ");
            
            // loop para contar ou números informado
            for( double i = num; i >= 1; i-- )
            {
                // imprima
                System.Console.Write($"{i} x ");

                // calcule
                fatorial *= i;
            } // fim for
            // imprima
            System.Console.WriteLine($"\b\b= {fatorial}");
        } // fim main
    } // fim classe
} // fim namespace
