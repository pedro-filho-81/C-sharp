using System;

/*
    3.13 (Classe Employee) Crie uma classe chamada Employee que inclua três variáveis 
    de instância — um primeiro nome (tipo String), um  sobrenome (tipo String) e um 
    salário mensal (double). Forneça um construtor que inicializa as três variáveis de 
    instância. Forneça um  método set e um get para cada variável de instância. 
    Se o salário mensal não for positivo, não configure seu valor. Escreva um aplicativo 
    de  teste chamado EmployeeTest que demonstre as capacidades da classe Employee. 
    Crie dois objetos Employee e exiba o salário anual  de cada objeto. Então dê a cada 
    Employee um aumento de 10% e exiba novamente o salário anual de cada Employee. 
    Deitel, Paul; Deitel, Harvey. Java: como programar (p. 77). Edição do Kindle. 
    Autor: Pedro Filho, 05/04/2021
*/

namespace Emprego
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria o objeto da classe Empregado
            Empregado funcionario1 = new Empregado("Pedro", "Filho", 1000M );
            Empregado funcionario2 = new Empregado( "Maria", "Padilha", 1000M );

            // cabeçalho
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine($"RELAÇÃO DOS EMPREGADOS");
            Console.ResetColor();

            // mosta o funcionário
            Console.WriteLine($"Nome: {funcionario1.Nome, -10} " +
                $"Sobre Nome: {funcionario1.SobreNome, -10} Salário {funcionario1.Salario, 7:C}");

            // mosta o funcionário
            Console.WriteLine($"Nome: {funcionario2.Nome, -10} " +
                $"Sobre Nome: {funcionario2.SobreNome, -10} Salário {funcionario2.Salario, 7:C}");

            System.Console.Write("Informe o valor percentual de Almento do salário: " );
            decimal percentual = decimal.Parse( Console.ReadLine());

            // cabeçalho 
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine($"RELAÇÃO DOS EMPREGADOS COM ALMENTO DE SALÁRIO");
            Console.ResetColor();

            // mosta o funcionário
            decimal almentoSalario = ( funcionario1.Salario * percentual / 100 ) + funcionario1.Salario;
            Console.WriteLine($"Nome: {funcionario1.Nome, -10} " +
                $"Sobre Nome: {funcionario1.SobreNome, -10} Salário {almentoSalario, 7:C}");
            
            // mosta o funcionário
            almentoSalario = ( funcionario2.Salario * percentual / 100 ) + funcionario2.Salario;
            Console.WriteLine($"Nome: {funcionario2.Nome, -10} " +
                $"Sobre Nome: {funcionario2.SobreNome, -10} Salário {almentoSalario, 7:C}");

            Console.ReadKey(); // pausa o programa
            Console.Clear(); // limpa a tela

        } // fim main
    } // fim classe
} // fim namespace
