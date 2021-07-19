using System;
using static System.Console;

namespace InstrucaoIf
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();
            
            // entrada de dados
            Write("Digite o primeiro número: ");
            int numero1 = int.Parse(ReadLine());

            Write("Digite o segundo número: ");
            int numero2 = int.Parse(ReadLine());

            // veriicar se número 1 igual ao 2
            if(numero1 == numero2 )
            {
                WriteLine($"{numero1} = {numero2}");
            } 

            // se número 1 diferente de 2
            if( numero1 != numero2 );
            {
                WriteLine($"{numero1} != {numero2}");
            }

            if( numero1 > numero2 )
            {
                WriteLine( $"{numero1} > {numero2}");
            }

            if( numero1 < numero2 )
            {
                WriteLine( $"{numero1} < {numero2}");
            }

            if( numero1 >= numero2 )
            {
                WriteLine( $"{numero1} >= {numero2}");
            }

            if( numero1 <= numero2 )
            {
                WriteLine( $"{numero1} <= {numero2}");
            }

            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim name
