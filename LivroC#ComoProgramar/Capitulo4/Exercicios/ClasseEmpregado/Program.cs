using System;
using static System.Console;

namespace ClasseEmpregado
{
    class Program
    {
        /*
            3.13 (Classe Employee) Crie uma classe chamada Employee que inclua três variáveis 
            de instância — um primeiro nome (tipo String), um  sobrenome (tipo String) e um 
            salário mensal (double). Forneça um construtor que inicializa as três variáveis 
            de instância. Forneça um  método set e um get para cada variável de instância. 
            Se o salário mensal não for positivo, não configure seu valor. Escreva um aplicativo 
            de  teste chamado EmployeeTest que demonstre as capacidades da classe Employee. 
            Crie dois objetos Employee e exiba o salário anual  de cada objeto. Então dê a cada 
            Employee um aumento de 10% e exiba novamente o salário anual de cada Employee. 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 77). Edição do Kindle. 
            Autor: Pedro Filho, 07/06/2021.
        */
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria objetos da classe empregado
            Empregado funcionario1 = new Empregado("Pedro", "Filho", 1000m );
            Empregado funcionario2 = new Empregado("Cleonice", "Morais", 900m );

            WriteLine($"{funcionario1.primeiroNome} {funcionario1.ultimoNome}" +
                        $"\nSalário inicial {funcionario1.SalarioMensal:C}" +
                        $"\nSalário anual {funcionario1.SalarioAnual(1000m):C}");

            WriteLine($"\n{funcionario2.primeiroNome} {funcionario2.ultimoNome}" +
                        $"\nSalário inicial {funcionario2.SalarioMensal:C}" +
                        $"\nSalário anual {funcionario2.SalarioAnual(900m):C}");

            Console.WriteLine("Hello World!");
        }
    }
}
