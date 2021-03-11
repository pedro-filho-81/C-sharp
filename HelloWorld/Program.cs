using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // entrada de dados
            Console.WriteLine("Qual é o seu nome? ");
            // cria a variável name e aguarda a entrada do usuário
            var name = Console.ReadLine();
            // cria a variável date que recebe a hora atual
            var date = DateTime.Now;
            
            /* o ( $ ) na frente da cadei de caracteres permite que
            coloque expressões como nomes de variáveis entre chaves,
            essa sintax pe conhecida como CADEIAS DE CARACTERES INTERPOLADAS*/
            Console.WriteLine($"{Environment.NewLine}Olá, {name}\nhoje é {date:d} às {date:t}!");
            Console.WriteLine($"{Environment.NewLine}Precione qualquer tecla para sair.");
            
            Console.ReadKey(true); // aguarda que se precione uma tecla
        }
    }
}
