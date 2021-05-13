using System;
using static System.Console;

namespace ListaDeArgumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria variáveis
            var valor1 = 10.0;
            var valor2 = 20.0;
            var valor3 = 30.0;
            var valor4 = 40.0;
            var valor5 = 50.0;

            // imprime resultado
            WriteLine($"\nvalor1 = {valor1:f1}\nvalor2 = {valor2:f1}\nvalor3 = {valor3:f1}" );
            WriteLine($"valor4 = {valor4:f1}\nvalor5 = {valor5:f1}" );

            WriteLine($"Média de valor1 e valor2 = {Media(valor1, valor2):f1}" );
            WriteLine($"Média de valor3 e valor5 = {Media(valor3, valor5):f1}" );
            WriteLine($"Média de valor2 e valor4 = {Media(valor2, valor4):f1}" );
            WriteLine($"Média de valor1, valor2, e valor3 = {Media(valor1, valor2, valor3):f1}" );
            WriteLine($"Média do valor1, valor2, valor3 e valor4 é {Media(valor1, valor2, valor3, valor4):F1}");
            Console.WriteLine("Hello World!");
        } // fim main

        // cria o método Média
        static double Media(params double[] numeros )
        {
            // cria variável
            var total = 0.0;

            // cria um loop para percorrer o vetor
            foreach( var valor in numeros )
            {
                // variável total soma os valores do vetor números 
                total += valor;
            } // fim foreach

            // retorne o tamanho do número
            return numeros.Length != 0 ? total / numeros.Length:0.0;
        } // fim função

    } // fim classe
} // fim namespace
