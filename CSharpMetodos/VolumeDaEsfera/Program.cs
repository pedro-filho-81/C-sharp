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
