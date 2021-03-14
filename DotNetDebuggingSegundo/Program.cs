using System;
// para possibilitar o uso do Debug
using System.Diagnostics;

namespace DotNetDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DEPURAÇÃO DO CONSOLE");
            int result = Fibonacci(6);
            Console.WriteLine($"RESULT = {result}");
        }
        static int Fibonacci(int n)
        {
            // variáveis ineiras
            int n1 = 0;
            int n2 = 1;
            int sum = 0;
            
            // adicionar Debug
            Debug.WriteLine($"Entre com o método {nameof(Fibonacci)}");
            Debug.WriteLine($"Nós estamos olhando para o número {n}");

            
            for (int i = 2; i <= n; i++)
            {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
                // debug se sum igual a 1
                Debug.WriteLineIf(sum == 1, $"sum é 1, n1 é {n1}, n2 é {n2}");
            }
            Debug.Assert(n2 == 5, "O valor do retorno não é 5 e deveria ser.");
            return n == 0 ? n1 : n2;
        }
    }
}
