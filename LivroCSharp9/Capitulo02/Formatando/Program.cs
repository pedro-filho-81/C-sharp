using System;

namespace Formatando
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Console.Clear();
            
            // cria variáveis
            int numeroDeMacaes = 12;
            decimal precoPorMacaes = 0.35M;
            // imprime
            Console.WriteLine(format:"{0} maçães consta {1:C}", arg0: numeroDeMacaes, arg1: precoPorMacaes *
                numeroDeMacaes );

            // cria variável e atribui valor
            string formatado = string.Format( format: "{0} maçães custam {1:C}", arg0: numeroDeMacaes, 
                arg1: precoPorMacaes * numeroDeMacaes );
            // imprime a variável
            Console.WriteLine($"{formatado} Hello World!");
        } // fim main
    } // fim classe
} // fim namespace
