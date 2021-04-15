using System;

namespace PalindromoDeInteiros
{
    class Program
    {
        /*
            4.30 (Palíndromos) Um palíndromo é uma sequência de caracteres que é lida da 
            esquerda para a direita ou da direita para a esquerda. Por  exemplo, cada um 
            dos seguintes inteiros de cinco dígitos é um palíndromo: 12321, 55555, 45554 
            e 11611. Escreva um aplicativo que lê em  um inteiro de cinco dígitos e determina 
            se ele é ou não um palíndromo. Se o número não for de cinco dígitos, exiba uma 
            mensagem de  erro e permita que o usuário insira um novo valor. 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 117). Edição do Kindle. 
            Autor: Pedro Filho, 15/04/2021
        */
        static void Main(string[] args)
        {
            // cria variável
            int num = 0;
            int n1, n2, n3, n4, n5;
            int sentinela = 0;

            // enquanto sentinela diferente de -1
            while( sentinela != -1 )
            {
                System.Console.WriteLine("Digite um inteiro de 5 digitos: ");
                num = int.Parse(Console.ReadLine());

                // calcular
                n1 = num / 10000;
                n2 = num % 10000 / 1000;
                n3 = num % 1000 / 100;
                n4 = num % 100 / 10;
                n5 = num % 10 / 1;

                // verificar se n5 é igual a n1 E n4 igual a n2
                if( n5 == n1 && n4 == n2 )
                {
                    System.Console.WriteLine($"O número {num} é um palíndromo.");
                } // fim if
                else // se não
                {
                    System.Console.WriteLine($"O número {num} não é um palíndromo.");
                } // fim se não

                System.Console.Write($"Deseja ver outro número? [1-sim / -1-não]");
                // aguarda usuário
                sentinela = int.Parse(Console.ReadLine());                
            } // fim while

            Console.Clear(); // limpa a tela
            
        } // fim main
    } // fim classe
} // fim namespace
