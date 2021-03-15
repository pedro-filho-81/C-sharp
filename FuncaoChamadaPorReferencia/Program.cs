using System;

namespace FuncaoChamadaPorReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // variável
            int valor = 50;
            // cria objeto da classe Program
            Program programa = new Program();

            Console.WriteLine($"O valor antes da função é {valor}");

            // chama a função
            // a palavra-chave REF faz a passagem por referência
            programa.funcaoPorReferencia(ref valor);           

            Console.WriteLine($"O valor após a função é {valor}");


        } // fim main

        // cria a função
        public void funcaoPorReferencia( ref int val)
        {
            // cálculo
            val *= val;

            // imprime
            Console.WriteLine($"O Valor dentro da função é {val}");
        } // fim função

    } // fim classe
} // fim namespace
