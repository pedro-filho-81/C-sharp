using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int contador = 0;
            int resultado = 1;
            int sentinela = 1;
            
            // loop sentinela
            while( sentinela != -1 )
            {    
                Console.Clear(); // limpa a tela
                
                // cabeçalho
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine( "CÁLCULO DO FATORIAL" );
                Console.ResetColor();

                System.Console.Write("Informe o valor para o fatorial: " );
                contador = int.Parse(Console.ReadLine() );

                // imprime o valor do contador
                System.Console.Write($"{contador}! = " );
                
                // loop para calcular o valor do fatorial
                while( contador >= num )
                {
                    // imprime a multiplicação para o fatorial
                    System.Console.Write($"{contador} x ");
                    // cálculo do fatorial
                    resultado *= contador;
                    contador--; // incrementa o contador em 1
                }  // fim while

                // imprime o resultado
                Console.WriteLine($"\b\b = {resultado}");
                
                System.Console.Write("Deseja continuar? [ 1 = sim / -1 = não ] " );
                sentinela = int.Parse(Console.ReadLine());
                contador = 0; // inicializa contador
                contador = 5;
                resultado = 1;

            } // fim while externo

        } // fim main
    } // fim classe
} // fim namespace
