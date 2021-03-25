using System;

namespace ComparandoInteiros2_16
{
    class Program
    {
        static void Main(string[] args)
        {
            // variáveis
            int num1, num2;

            // entrada de dados
            Console.Write("Primeiro número: ");
            int.TryParse(Console.ReadLine(), out num1);
            Console.Write("Segundo número: ");
            int.TryParse(Console.ReadLine(), out num2);

            // condições de verificação
            if( num1 > num2)
            {
                Console.WriteLine($"[{num1, -5}] é maior que [{num2, 5}]");
            }
            if(num1 < num2)
            {
                Console.WriteLine($"{num1} é menor que {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} é igual a {num2}");
            }
            Console.ReadKey();

            Console.WriteLine("Hello World!");
        }
    }
}
