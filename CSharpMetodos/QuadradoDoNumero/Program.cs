using System;
using static System.Console;


namespace QuadradoDoNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria uma variável
            int num = 0;

            // limpa a tela
            Clear();

            // entrada de dados
            Write("Digite um número para ver o seu quadrado: " );
            // aguarda a entrada do usuário
            num = int.Parse(Console.ReadLine());
            
            // chama o método e atribui o valor da variável double resposta
            double resposta = QuadradoDeNum(num);

            // mosta a resposta
            Console.WriteLine($"O quadrado de {num} é {resposta:n0}");

            // pula linha
            System.Console.WriteLine();

            // loop para ver o quadrado de um número
            for( int i = 1; i <= 10; i++ )
            {
                // cria uma variável
                double resp = QuadradoDeNum(i);
                // imprime
                WriteLine($"o quadra de {i} é {resp}");
            } // fim loop for

            ReadKey();
            Clear();
            
        } // fim main

        // método Quadrado do número
        // recebe um valor no parâmetro double num
        public static double QuadradoDeNum( Double num  )
        {
            // retorna o valor de num vezes num
            return num * num;
        } // fim método

    } // fim classe
} // fim namespace
