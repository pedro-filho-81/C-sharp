using System;
using System.Linq;
using static System.Console;

namespace ClasseEmpregado
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria e inicializa array de empregados
            var empregados = new[] {

                new Empregado("Pedro", "Filho", 5123.25M),
                new Empregado("Ashley", "Green", 7600m),
                new Empregado("Matheus", "Indigo", 3564.2m),
                new Empregado("James", "Indigo", 4600.78m),
                new Empregado("Luck", "Indigo", 6200.15m),
                new Empregado("Jason", "Blue", 3200m),
                new Empregado("Wendy", "Brown", 4236.4m),

            }; // fim array empregado

            // cabeçalho
            WriteLine("VETOR ORIGINAL" );
            // loop para mostrar todos os empregados
            foreach(var funcionario in empregados )
            {
                // imprima
                WriteLine($"{funcionario}" );
            } // fim foreach

            WriteLine("\nVETOR ORGANIZADO PELO SALÁRIO");
            // cria uma consulta ao vetor empregados
            var entreValores = from valor in empregados orderby valor.SalarioMensal select valor;
            foreach(var sal in entreValores)
            {
                WriteLine($"{sal}"); 
            }

        } // fim main
    } // fim classe
} // fim namespace
