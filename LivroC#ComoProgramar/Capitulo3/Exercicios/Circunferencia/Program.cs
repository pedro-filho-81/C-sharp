using System;
using static System.Console;

namespace Circunferencia
{
    class Program
    {
        /*
            3,26 (Diâmetro, Circunferência e Área de um Círculo)
            Aqui está uma espiada à frente. Neste capítulo, você aprendeu sobre inteiros e o tipo int. 
            C # também pode representar números de vírgula flutuante que contêm vírgulas decimais, 
            como 3,14159. Escreva um aplicativo que insere do usuário o raio de um círculo como um 
            número inteiro e exibe o diâmetro, a circunferência e a área do círculo usando o valor 
            de ponto flutuante 3,14159 para π. Use as técnicas mostradas na Fig. 3.14. [Nota: Você 
            também pode usar a constante predefinida Math.PI para o valor de π. Essa constante é mais 
            precisa do que o valor 3,14159. A classe Math é definida no namespace System]. 
            Use as seguintes fórmulas (r é o raio): diâmetro = 2r circunferência = 2πr área = πr2 
            Não armazene o resultado de cada cálculo em uma variável. Em vez disso, especifique cada 
            cálculo como o valor a ser gerado em uma instrução Console.WriteLine. Os valores produzidos 
            pelos cálculos de circunferência e área são números de ponto flutuante. Você aprenderá mais 
            sobre isso no Capítulo 5.
            Autor: Pedro Filho, 22/07/2021
        */

        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cabeçalho
            WriteLine("ÁREA, CIRCUNFERÊNCIA, DIÂMETRO DA CIRCUNFERÊNCIA");

            // variável
            int raio;

            // entrada de dados
            Write("Digite o valor do raio: ");
            raio = int.Parse(ReadLine());

            // mostra resultados
            WriteLine($"Raio = {raio}");
            WriteLine($"Diâmetro = {raio * 2}" );
            WriteLine($"Área = {(raio * raio) * 3.14159 }" );
            WriteLine($"Circunferência = {2 * 3.14159 * raio }" );

            // fim programa
            ReadKey();

        } // fim main
    } // fim classe
} // fim name
