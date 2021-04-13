using System;
using static System.Console;

namespace CalculadorDeSalarios
{
    class Program
    {
        /*
            4.20 (Calculador de salários) Desenvolva um aplicativo Java que determina 
            o salário bruto de cada um de três empregados. A empresa paga  as horas normais 
            pelas primeiras 40 horas trabalhadas por cada funcionário e 50% a mais por 
            todas as horas trabalhadas além das 40  horas. Você recebe uma lista de empregados, 
            o número de horas trabalhadas por eles na semana passada e o salário-hora de 
            cada um. Seu  programa deve aceitar a entrada dessas informações para cada empregado 
            e, então, determinar e exibir o salário bruto do empregado.  Utilize a classe Scanner 
            para inserir os dados. 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 115). Edição do Kindle. 
            Autor: Pedro Filho - 13/04/2021
        */
        static void Main(string[] args)
        {    
            // variáveis
            string func;
            decimal valorDaHora = 0m;
            decimal salario = 0m;
            int horasTrabalhadas = 0;
            int sentinela = 1;

            // enquanto contador menor ou igual a 3
            while( sentinela != -1 )
            {
                Clear(); // limpa a tela

                // entrada de dados
                Write( "Nome do funcionário: " );
                // aguarda entrada do usuário
                func = ReadLine();

                Write("Valor das horas trabalhadas R$" );
                // aguarda usuário
                valorDaHora = decimal.Parse( ReadLine() );
                
                Write("Total de horas trabalhadas:");
                // aguarda usuário
                horasTrabalhadas = int.Parse(ReadLine());

                // cálculo do salário
                // se horas trabalhadas menor ou igual a 40 horas
                if( horasTrabalhadas <= 40 )
                {
                    // salario recebe
                    salario = valorDaHora * horasTrabalhadas;
                } // fim if
                else // se não
                {
                    // cria variável horas extras e atribui o valor das extras
                    decimal horasExtras = ( horasTrabalhadas - 40 ) * (valorDaHora / 2 );
                    // salario recebe o valor da expressão
                    salario = ( valorDaHora * 40 ) + horasExtras;
                } // fim else

                // mostra resultado
                WriteLine($"\nFuncionário {func}\nTrabalhou {horasTrabalhadas} horas");
                WriteLine($"Salário {salario:C}" );
                
                WriteLine(); // pula linha

                Console.Write("Deseja cadastrar outro funcionário? [ 1=sim / -1=não ]: " );
                sentinela = int.Parse(ReadLine());

                Clear(); // limpa a tela

            } // fim while
        } // fim main
    } // fim classe
} // fim namespace
