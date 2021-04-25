using System;

namespace VariavelNula
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria variáveis
            // int esteNaoPodeSerNulo = null;
            // atribuindo valor
            // esteNaoPodeSerNulo = 4;
            // mostra
            // .Console.WriteLine($"Este não pode ser nulo {esteNaoPodeSerNulo}");

            // este pode ser nulo
            int? estePodeSerNulo = null;
            Console.WriteLine($"Este pode ser nulo {estePodeSerNulo}");

            // atribuindo valores
            estePodeSerNulo = 7;
            Console.WriteLine($"Este pode ser nulo vale {estePodeSerNulo}");
            Console.WriteLine($"Este pode ser nulo {estePodeSerNulo.GetValueOrDefault()}");
        } // fim main
    } // fim classe
} // fim namespace
