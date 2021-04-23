using System;

namespace MetodoMaiorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados
            Console.Write("Informe 3 números diferentes: ");
            // cria variáveis e aguarda a entrada de dados pelo usuário
            double numero1 = double.Parse(Console.ReadLine());
            double numero2 = double.Parse(Console.ReadLine());
            double numero3 = double.Parse(Console.ReadLine());

            // cria a variável e atribui o método maior valor
            // método maior valor recebe os argumentos n1, n2, n3
            double resposta = MaiorValor(numero1, numero2, numero3 );

            // mostra o resultado
            Console.WriteLine($"O maior valor é {resposta}");
            Console.ReadKey();
            Console.Clear();

        } // fim main

        static double MaiorValor( double x, double y, double z )
        {
            double maiorValor = x; // maior valor recebe x

            // se y maior que maior valor
            if( y > maiorValor )
                maiorValor = y; // maior valor recebe y
            
            // se z maior que o maior valor
            if( z > maiorValor )
                maiorValor = z; // maior valor recebe z

            return maiorValor; // retorne o maior valor
        } // fim método

    } // fim classe
} // fim namespace
