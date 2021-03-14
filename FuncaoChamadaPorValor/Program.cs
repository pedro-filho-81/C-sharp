using System;

namespace FuncaoChamadaPorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria variável
            int val = 50;
            // cria o objeto da classe
            Program programa = new Program();

            Console.WriteLine($"O valor da variável {val} sem alteração.");

            // chama a função e passa o valor da variável val
            programa.MostraValor(val);

            Console.WriteLine($"O valor depois da variável é {val}\n");
            Console.WriteLine("Precione qualquer tecla para");
            Console.ReadKey();
            
        } // fim main

        // cria função chamada por valor
        // função chamada por valor, o valor atribuido a ela não se modifica
        // o valor dentro da função pode mudar
        public void MostraValor( int valor)
        {
            // cálculo
            valor *= valor;
            // imprime
            Console.WriteLine($"Valor alterado na função {valor}");
        }// fim da função

    } // fim classe
} // fim namespace
