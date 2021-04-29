using System;
using static System.Console;

namespace VolumeDaEsfera
{
    class Program
    {
        // calcular o volume de uma esfera

        static void Main(string[] args)
        {
            // cria variável
            double raioDaEsfera = 0;

            // limpa a tela
            Clear();

            // cabeçalho
            BackgroundColor = ConsoleColor.DarkBlue;
            ForegroundColor = ConsoleColor.White;
            WriteLine("VOLUME DA ESFERA");
            ResetColor();

            // entrada de dados
            Write("Digite o raio da esfera: ");
            raioDaEsfera = int.Parse(ReadLine());
            
            // imprime resultado
            WriteLine($"O volume da esfera é {Volume(raioDaEsfera):n5}");

            // cabeçalho
            BackgroundColor = ConsoleColor.DarkBlue;
            ForegroundColor = ConsoleColor.White;
            WriteLine("VALOR DE X");
            ResetColor();

            // valor de x
            WriteLine($"Math.Abs(7.5) = {Math.Abs(7.5)}");
            WriteLine($"Math.Floor(7.5) = {Math.Floor(7.5)}");
            WriteLine($"Math.Abs(0.0) = {Math.Abs(0.0)}");
            WriteLine($"Math.Ceiling(0,0) = {Math.Ceiling(0.0)}");
            WriteLine($"Math.Abs(-7.5) = {Math.Abs(-7.5)}");
            WriteLine($"Math.Ceiling(-7.5) = {Math.Ceiling(-7.5)}");
            WriteLine($"Math.Celing(-Math.Abs(-8 + Math.Floor(-5.5)) = {Math.Ceiling(-Math.Abs(-8 + Math.Floor(-5.5)))}");
            // fim
            ReadKey();
            Clear(); // limpa a tela
            
        } // fim main

        // método Volume
        public static double Volume( double raio )
        {
            // calcula o volume
            double volumeDaEsfera = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3 );
            return volumeDaEsfera;
        } // fim Volume

    } // fim classe
} // fim namespace
