using System;
using static System.Console;
/*
 * 2.26 (Múltiplos) Escreva um aplicativo que leia dois inteiros, além de determinar 
 *  se o primeiro é um múltiplo do segundo e imprimir o resultado. [Dica: utilize 
 *  o operador de resto.] 
    Deitel, Paul; Deitel, Harvey. Java: como programar (p. 53). Edição do Kindle. 
    Autor: Pedro Filho, 26/03/2021
 * */
namespace Multiplos2_26
{
    class Program
    {
        static void Main(string[] args)
        {
            // variáveis
            int n1, n2;

            // entrada de dados
            Write("Primeiro inteiro: ");
            int.TryParse(ReadLine(), out n1);

            Write("Segundo inteiro: ");
            int.TryParse(ReadLine(), out n2);

            // verificar se n1 é multlo de n2
            if(n1 % n2 == 0)
            {
                WriteLine($"{n1} é multiplo de {n2}");
            }
            // verifica se n2 é multiplo de n1
            if(n2 % n1 == 0)
            {
                WriteLine($"{n2} é multiplo de {n1}");
            }

            ReadKey(); // pausa o programa
        }
    }
}
