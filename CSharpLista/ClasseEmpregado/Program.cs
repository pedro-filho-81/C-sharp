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

            // cabeçalho
            WriteLine("\nVETOR ORGANIZADO PELO SALÁRIO ENTRE 4 E 6 MIL");

            // cria uma consulta ao vetor empregados
            var entreValores = // CRIA a variável para consulta
            from valor in empregados // de valor em vetor empregado
            orderby valor.SalarioMensal // ordena o vetor pelo salário mensal
            // condiciona consulta para mostrar os salários entre R$4000 e R$6000
            where (valor.SalarioMensal >= 4000m) && (valor.SalarioMensal <= 6000m)
            select valor; // seleciona o valor
            
            // loop para mostrar os valores da consulta
            // para cada salário entre os valores da consulta
            foreach(var sal in entreValores)
            {
                // imprima
                WriteLine($"{sal}"); 
            } // fim consulta entre valores

            // cria a consulta organizada pelo último e primeiro nome
            var sorteiaNome = // variávelque recebe a consulta
            from nome in empregados // pesquisa pelo nome do empregado
            orderby nome.UltimoNome, nome.PrimeiroNome // ordena pelo último e primeiro nome
            select nome; // seleciona o nome

            if(sorteiaNome.Any())
            {
                WriteLine(sorteiaNome.First());
            } // fim if
            else
            {
                WriteLine("Nome não encontrado.");
            }

            // cria consulta pelo último nome
            var ultimoNome = 
            from nome in empregados
            select nome.UltimoNome;

            // cabeçalho
            WriteLine("\nVETOR ORGANIZADO PELO ÚLTIMO NOME" );

            // LOOP para mostrar os nomes organizados
            foreach( var nome in ultimoNome.Distinct() )
            {
                // imprima
                WriteLine($"{nome}" );
            } // fim mostra nomes

            // consulta
            var nomes = // variável que recebe a consulta
            from nome in empregados // consulta pelo nome do empregado
            // seleciona o primeiro nome
            select new {nome.PrimeiroNome, nome.UltimoNome};

            // cabeçalho
            WriteLine($"\nAPENAS NOMES");
            foreach( var elemento in nomes )
            {
                WriteLine($"{elemento}" );
            } // fim foreach

        } // fim main
    } // fim classe
} // fim namespace
