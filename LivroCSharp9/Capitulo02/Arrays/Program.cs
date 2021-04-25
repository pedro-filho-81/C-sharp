using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria um array
            string[] nomes; // pode referenciar qualquer array de string
            
            // alocando memoria para 4 string em um array
            nomes = new string[ 4 ];
            
            // limpa a tela
            Console.Clear();
            
            // indexando valores para o array
            nomes[0] = "Pedro";
            nomes[1] = "Paulo";
            nomes[2] = "Maria";
            nomes[3] = "José";
            
            // loop para mostrar os nomes
            for( int i = 0; i < nomes.Length; i++ )
            {
                System.Console.WriteLine($"Nomes[{i}] = {nomes[i]}");
            } // fim for

            Console.WriteLine("Hello World!");
        }
    }
}
