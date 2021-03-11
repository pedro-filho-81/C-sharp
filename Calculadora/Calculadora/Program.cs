using System;

namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value is "not-a-number" which we use if an operation, such as division, could result in an error.

            // Use a switch statement to do the math.
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    // se num2 diferente de zero 
                    if (num2 != 0)
                    {
                        // faça o cálculo
                        result = num1 / num2;
                    }
                    break;
                // Retorna para o texto no caso de uma opção incorreta
                default:
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Display title as the C# console calculator app.
            Console.WriteLine("CALCULADORA EM C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                // VARIÁVEIS.
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                // entrada do primeiro número
                Console.Write("Digite o primeiro número: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Este não é um valor válido! Digite um número: ");
                    numInput1 = Console.ReadLine();
                }

                // entrada do segundo número
                Console.Write("Digite o segundo número: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Este não é um valor válido! Digite um número: ");
                    numInput2 = Console.ReadLine();
                }

                // menu aritimética
                Console.WriteLine("MENU ARITIMÉTICA");
                Console.WriteLine("\t+ - Adição");
                Console.WriteLine("\t- - Subtração");
                Console.WriteLine("\t* - Multiplicação");
                Console.WriteLine("\t/ - Divisão");
                Console.Write("Qual a sua opção? ");

                // recebe a opção do usuário
                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Esta não é uma operação válida na matemática.\n");
                    }
                    else Console.WriteLine("Resultado: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Tecle 'n' e Enter para sair ou outra tecla para continuar.: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            } // fim while endApp
            return;
        } // fim main
    } // fim classe
} // 