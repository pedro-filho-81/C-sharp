using System;
using static System.Console;

namespace RolaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria o objeto randômico
            Random numerosAleatorios = new Random();

            // cria variáveis frequência
            int frequencia1 = 0;
            int frequencia2 = 0;
            int frequencia3 = 0;
            int frequencia4 = 0;
            int frequencia5 = 0;
            int frequencia6 = 0;

            // loop para gerar 60000 números entre 1 e 6
            for( int i = 0; i < 60000; i++ )
            {
                // se i igual a multiplos de 20
                if( i % 20 == 0 )
                    // pula uma linha
                    WriteLine();

                // cria variável que recebe números aleatórios entre 1 e 6
                int face = numerosAleatorios.Next( 1, 7 );

                // mostra os números
                Write( $"{face} " );
                    
                // cria switch
                switch( face )
                {
                    case 1:
                        frequencia1++;
                        break;
                    case 2:
                        frequencia2++;
                        break;
                    case 3:
                        frequencia3++;
                        break;
                    case 4:
                        frequencia4++;
                        break;
                    case 5:
                        frequencia5++;
                        break;
                    case 6:
                        frequencia6++;
                        break;
                } // fim switch

            } // fim for

            // cabeçalho
            WriteLine("\nFREQUÊNCIA DE DADO");
            WriteLine("Face\tFrequência");
            WriteLine($"1\t{frequencia1}\n2\t{frequencia2}");
            WriteLine($"3\t{frequencia3}\n4\t{frequencia4}");
            WriteLine($"5\t{frequencia5}\n6\t{frequencia6}");

        } // fim main
    } // fim classe
} // fim namespace
