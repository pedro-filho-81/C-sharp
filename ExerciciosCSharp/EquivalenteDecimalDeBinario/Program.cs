using System;

namespace EquivalenteDecimalDeBinario
{
    class Program
    {
        /*
            4.31 (Imprimindo o equivalente decimal de um número binário) Escreva um aplicativo 
            que insere um número inteiro que contém somente 0s e 1s (isto é, um número inteiro binário) 
            e imprime seu equivalente decimal. [Dica: utilize os operadores de resto e divisão para  
            pegar os dígitos do número binário um de cada vez da direita para a esquerda. 
            No sistema de números decimais, o dígito mais à direita  tem um valor posicional de 1 
            e o próximo dígito à esquerda um valor posicional de 10, depois 100, depois 1.000 e assim 
            por diante. O  número decimal 234 pode ser interpretado como 4 * 1 + 3 * 10 + 2 * 100. 
            No sistema de número binário, o dígito mais à direita tem um  valor posicional de 1, 
            o próximo dígito à esquerda um valor posicional de 2, depois 4, depois 8 e assim por diante. 
            O equivalente decimal  do binário 1.101 é 1 * 1 + 0 * 2 + 1 * 4 + 1 * 8 ou 1 + 0 + 4 + 8 ou 13.] 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 117). Edição do Kindle. 
            Autor: Pedro Filho 15/04/2021
        */
        static void Main(string[] args)
        {
            // cria variáveis
            int valorBinario = 0;
            int binario = 0;
            double valorDecimal = 0;
            int contador = 0;
            int sentinela = 1;

            // enquanto sentinela diferente de -1
            while( sentinela != -1 )
            {
                // limpa a tela
                Console.Clear();

                // entrada de dados
                Console.Write("Entre com o valor binário: ");
                valorBinario = int.Parse( Console.ReadLine());
                binario = valorBinario;

                // enquanto binário maior que zero faça
                while( valorBinario > 0 )
                {
                    valorDecimal += Math.Pow( 2, contador ) * ( valorBinario % 10 );
                    valorBinario /= 10;
                    contador++;
                
                } // fim while

                Console.WriteLine($"O valor binário {binario} equivale a {valorDecimal} em decimal.");

                // limpa variáveis
                valorBinario = 0;
                valorDecimal = 0;
                contador = 0;
                
                // perguta se quer continuar
                System.Console.Write("Quer continuar? [ 1=sim / -1=não ] ");
                sentinela = int.Parse(Console.ReadLine());

            } // fim while externo

            // limpa a tela
            Console.Clear();            
        }
    }
}
