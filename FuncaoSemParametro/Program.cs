using System;

namespace FuncaoSemParametro
{
    class Program
    {
        // cria uma função sem parametro
        public void Mostrar() // sem parâmetro
        {
            // imprime
            Console.WriteLine("Esta é uma função não parametrizada.");
        }
        static void Main(string[] args)
        {
            // cria o objeto da classe programa
            Program programa = new Program();

            // chama a função criada acima Mostrar
            programa.Mostrar();

        } // fim de main
    } // fim classe
} // fim namespace
