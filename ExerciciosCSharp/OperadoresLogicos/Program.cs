using System;

namespace OperadoresLogicos
{
    class Program
    {
        /*
            Cria um tabela para os operadores lógicos
            Pedro Filho, 21/04/2021
        */
        static void Main(string[] args)
        {
            // limpa a tela
            Console.Clear();

            // cabeçalho
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\tTABELA DO OPERADOR CONDICIONAL E ( && )");
            Console.ResetColor();

            // Título
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine($"{"Expressão1", 15}{"Expressão2", 15} {"Expressão1 && Expressão2", 30}    ");
            Console.ResetColor();

            // primeira linha
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine($"{"Verdadeiro", 15}{"Verdadeiro", 15} {"Verdadeiro", 23}           ");
            Console.ResetColor();

            // segunda linha
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine($"{"Verdadeiro", 15}{"Falso", 12} {"Falso", 24}             ");
            Console.ResetColor();
  
            // terceira linha
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine($"{"Falso", 12}{"Verdadeiro", 18} {"Falso", 21}             ");
            Console.ResetColor();
            
            // quarta linha
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine($"{"Falso", 12}{"Falso", 15} {"Falso", 24}             ");
            Console.ResetColor();

            System.Console.WriteLine(); // pula uma linha

            // cabeçalho
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\tTABELA DO OPERADOR CONDICIONAL OU ( || )");
            Console.ResetColor();

            // Título
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine($"{"Expressão1", 15}{"Expressão2", 15} {"Expressão1 || Expressão2", 30}    ");
            Console.ResetColor();

            // primeira linha
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine($"{"Verdadeiro", 15}{"Verdadeiro", 15} {"Verdadeiro", 23}           ");
            Console.ResetColor();

            // segunda linha
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine($"{"Verdadeiro", 15}{"Falso", 12} {"Verdadeiro", 26}           ");
            Console.ResetColor();
  
            // terceira linha
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine($"{"Falso", 12}{"Verdadeiro", 18} {"Verdadeiro", 23}           ");
            Console.ResetColor();
            
            // quarta linha
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine($"{"Falso", 12}{"Falso", 15} {"Falso", 24}             ");
            Console.ResetColor();

            System.Console.WriteLine(); // PULA LINHA

            // cabeçalho
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\tTABELA DO OPERADOR BOLEANO LÓGICO E ( & )");
            Console.ResetColor();

            // Título
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine($"{"Expressão1", 15}{"Expressão2", 15} {"Expressão1 & Expressão2", 30}    ");
            Console.ResetColor();

            // primeira linha
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine($"{"Verdadeiro", 15}{"Verdadeiro", 15} {"Verdadeiro", 23}           ");
            Console.ResetColor();

            // segunda linha
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine($"{"Verdadeiro", 15}{"Falso", 12} {"Falso", 24}             ");
            Console.ResetColor();
  
            // terceira linha
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine($"{"Falso", 12}{"Verdadeiro", 18} {"Falso", 21}             ");
            Console.ResetColor();
            
            // quarta linha
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine($"{"Falso", 12}{"Falso", 15} {"Falso", 24}             ");
            Console.ResetColor();

            System.Console.WriteLine(); // pula uma linha

            // cabeçalho
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\tTABELA DO OPERADOR BOOLEANO LÓGICO OU ( | )");
            Console.ResetColor();

            // Título
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine($"{"Expressão1", 15}{"Expressão2", 15} {"Expressão1 | Expressão2", 30}    ");
            Console.ResetColor();

            // primeira linha
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine($"{"Verdadeiro", 15}{"Verdadeiro", 15} {"Verdadeiro", 23}           ");
            Console.ResetColor();

            // segunda linha
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine($"{"Verdadeiro", 15}{"Falso", 12} {"Verdadeiro", 26}           ");
            Console.ResetColor();
  
            // terceira linha
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine($"{"Falso", 12}{"Verdadeiro", 18} {"Verdadeiro", 23}           ");
            Console.ResetColor();
            
            // quarta linha
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine($"{"Falso", 12}{"Falso", 15} {"Falso", 24}             ");
            Console.ResetColor();

            System.Console.WriteLine(); // PULA LINHA

        }
    }
}
