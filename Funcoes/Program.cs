using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria o objedo da classe Program
            Program programa = new Program();

            // chama a função sem parâmetro
            programa.Mostrar();
            // chama a função Nome 
            programa.Nome("Pedro Filho");
            
            // cria variável mensagem que recebe método Show e atribui uma string
            string mensagem = programa.Show("Estou aprendendo a criar métodos em C#");
            Console.WriteLine($"A mensagem é: {mensagem}");
            
            // pausa o programa
            Console.WriteLine("Presione uma tecla para sair.");
            Console.ReadKey();

        } // fim main
        
        // cria uma função sem parâmetro
        public void Mostrar() // sem parâmetro
        {
            // imprime
            Console.WriteLine("Esta é uma função não parametrizada.");

        } // fim função sem parâmetro

        // cria a função Nome
        public void Nome(string nome) // parâmetro string nome
        {
            // imprime
            Console.WriteLine($"Olá, {nome} prazer te conhecer.\n");
        } // fim método

        // cria uma função que retorna uma mensagem
        public string Show(string mensagem) // parâmetro mensagem
        {
            Console.WriteLine("Eu sou uma mensagem interna");
            
            // retorne uma mensagem
            return mensagem;
        } // fum método Show

    } // fim classe
} // fim nomespace
