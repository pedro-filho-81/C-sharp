using System;

namespace ClasseConstrutorDestrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria o objeto da classe Empregado
            Empregado funcionario1 = new Empregado();
            Empregado funcionario2 = new Empregado();
            
            // cria o objeto da classe Empregado com parãmetro e atribui valores
            EmpregadoParametrizado func1 = new EmpregadoParametrizado();
            EmpregadoParametrizado func2 = new EmpregadoParametrizado();

            Console.WriteLine("Hello World!");

            // chama o construtor da classe Empregado e mostra o conteúdo
            funcionario1.ConstrutorFuncionario();
            funcionario2.ConstrutorFuncionario();

            //chama o construtor da classe Empregado parametrizado e atribui valores
            func1.ConstrutorFuncParametrizado(123, "Pedro", 1000f);
            func2.ConstrutorFuncParametrizado(321, "Maria", 500f);

            // chama o display e mostra o conteúdo
            func1.Display();
            func2.Display();

        } // fim main
    } // fim classe principal
} // fim namespace
