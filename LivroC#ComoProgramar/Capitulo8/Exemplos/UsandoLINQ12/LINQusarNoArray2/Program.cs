using System;
using static System.Console;
using System.Linq;

namespace UsandoLINQ12
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa tela
            Clear();

            // cria array empregados e inicializa
            var empregados = new[] {
                new Empregado("Jason", "Red", 5000m),
                new Empregado("Ashley", "Green", 7600m),
                new Empregado("Matthew", "indigo", 3587.5m),
                new Empregado("James", "Indigo", 4700.77m),
                new Empregado("Luck", "Indigo", 6200m),
                new Empregado("Jason", "Blue", 3200m),
                new Empregado("Wendy", "Brown", 4236.4m),
             };

            WriteLine("Array original:" );
            // loop mostra os elementos do array
            foreach( var elemento in empregados )
            {
                WriteLine($"{elemento} " );
            } // fim foreach

            // mostra valores maiores que 4000
            WriteLine($"\nValores maiores que {4000:c} e menores que {6000:c}");

            // filtrar
            var valorEntre4k6k = 
            from e in empregados
            where (e.Salario >= 4000m) && (e.Salario <=6000m)
            orderby e.Salario
            select e;

            foreach(var elemento in valorEntre4k6k )
            {
                WriteLine($"{elemento}");
            } // fim foreach




            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim name
