using System;
using static System.Console;

namespace EquivalenteIntDeCaractere
{
    class Program
    {
        /*
            3.27 (equivalente inteiro de um caractere) A seguinte instrução produz um caractere 
            e seu equivalente inteiro: Console.WriteLine ($ "O caractere {'A'} tem o valor {(int) 'A'}") ; 
            Quando a instrução anterior é executada, ela exibe o caractere A e o valor 65 como 
            parte da string. Consulte o Apêndice C para obter uma lista de caracteres e seus equivalentes 
            inteiros. Usando instruções semelhantes à mostrada anteriormente neste exercício, 
            escreva um aplicativo que exiba os equivalentes inteiros de algumas letras maiúsculas, 
            letras minúsculas, dígitos e símbolos especiais. Exiba os equivalentes inteiros do seguinte: 
            A B C a b c 0 1 2 $ * + / e o espaço.
            Autor: Pedro Filho, 22/07/2021
        */

        static void Main(string[] args)
        {
            // limpa a tela
            Clear();
            
            // cabeçalho
            WriteLine("EQUIVALENTE INTEIRO de CARACTERE");
            
            // entreda de dados
            Write("Digite um caractere: " );
            char caractere = char.Parse(ReadLine());

            // mostra resultado
            WriteLine($"O caractere [{caractere}] tem o valor inteiro [{(int) caractere}]");
        } // fim main
    } // fim classe
} // fim name
