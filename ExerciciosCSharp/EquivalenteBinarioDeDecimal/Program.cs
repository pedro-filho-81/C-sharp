using System;

namespace EquivalenteBinarioDeDecimal
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
            Pedro Filho 15/04/2021
        */
        static void Main(string[] args)
        {
            // cria variáveis
            int numeroDecimal = 0;
            int valorDecimal = 0;
            int binario = 0;
            int inverteBinario = 0;
            int contador = 0;
            int sentinela = 1;

            // enquanto sentinela diferente de -1
            while( sentinela != -1 )
            {
                // limpa a tela
                Console.Clear();

                // entre com um inteiro
                System.Console.Write("Entre com um número inteiro: ");
                numeroDecimal = int.Parse(Console.ReadLine());
                valorDecimal = numeroDecimal;

                // enquanto número decimal maior que zero faça
                while( numeroDecimal > 0 )
                {
                    // calcular
                    binario = (binario * 10 ) + (numeroDecimal % 2 );
                    numeroDecimal /= 2;
                    contador++;                
                } // fim while

                // enquanto número decimal maior que zero faça
                while( contador > 0 )
                {
                    contador--;
                    inverteBinario = (inverteBinario * 10 ) + (binario % 2 );
                    binario = (binario - (binario % 2 )) / 10;

                } // fim while

                // imprime resultado
                System.Console.WriteLine($"O valor {valorDecimal} equivale a {inverteBinario} em binário.");
                // inicializa inverte o binário
                inverteBinario = 0;
                binario = 1;
                contador = 0;
                
                // pergunta se quer continuar
                System.Console.WriteLine("Deseja continuar? [ 1=sim / -1=não ] ");
                sentinela = int.Parse(Console.ReadLine());

            } // fim while externo

            // limpa a tela
            Console.Clear();

        } // fim main
    } // fim classe
} // fim namespace
