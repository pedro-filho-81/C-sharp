using System;

namespace LancandoDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria o objeto randômico
            Random dado = new Random();
            
            // cria variáveis para verificar a frequência que o alea aparece
            int frequencia1 = 0;
            int frequencia2 = 0;
            int frequencia3 = 0;
            int frequencia4 = 0;
            int frequencia5 = 0;
            int frequencia6 = 0;

            Console.Clear(); // limpa a tela

            // cria loop para repetição
            for( int i = 1; i <= 6000000; i++ )
            {
                // cria variável que recebe números aleatórios entre 1 e 6
                // o último número sempre maior que o desejado
                // Exp: de 1 a 6 no lugar de 6 colocar 7
                int numerosAleatorios = dado.Next( 1, 7 );

                // cria switch
                switch( numerosAleatorios )
                {
                    case 1:
                        ++frequencia1;
                        break;
                    case 2:
                        ++frequencia2;
                        break;
                    case 3:
                        ++frequencia3;
                        break;
                    case 4:
                        ++frequencia4;
                        break;
                    case 5:
                        ++frequencia5;
                        break;
                    case 6:
                        ++frequencia6;
                        break;

                } // fim switch
                    
            } // fim for

            // imprime resultado
            // cabeçalho
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"FACE\tFREQUÊNCIA");
            Console.ResetColor();

            // imprime resultado
            System.Console.WriteLine($"1\t{frequencia1}");
            System.Console.WriteLine($"2\t{frequencia2}");
            System.Console.WriteLine($"3\t{frequencia3}");
            System.Console.WriteLine($"4\t{frequencia4}");
            System.Console.WriteLine($"5\t{frequencia5}");
            System.Console.WriteLine($"6\t{frequencia6}");

            // fim
            Console.ReadKey();
            Console.Clear();

        } // fim main
    } // fim classe
} // fim namespace
