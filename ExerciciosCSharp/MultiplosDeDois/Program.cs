using System;

namespace MultiplosDeDois
{
    class Program
    {
        /*
            4.33 (Múltiplos de 2 com um loop infinito) Escreva um aplicativo que continue 
            exibindo na janela de comando os múltiplos do inteiro 2  — a saber, 2, 4, 8, 
            16, 32, 64 e assim por diante. Seu loop não deve terminar (isto é, deve criar 
            um loop infinito). O que acontece quando  você executa esse programa? 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 117). Edição do Kindle. 
            Autor: Pedro Filho 16/04/2021
        */
        static void Main(string[] args)
        {
            // variável
            int contador = 2;
            // loop para contar todos os multiplos de 2
            while( contador % 2 == 0 )
            {
                if( contador % 2 == 0 )
                {
                    System.Console.WriteLine($"{contador} " );
                } // fim if
                contador += 2;
            } //fim while

        } // fim main
    } // fim classe
} // fim namespace
