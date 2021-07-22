using System;
using static System.Console;

namespace DigitosDeUmInteiro
{
    class Program
    {
        /*
            3.28 (Dígitos de um inteiro) Escreva um aplicativo que insira um número composto 
            por cinco dígitos do usuário, separe o número em seus dígitos individuais e exiba 
            os dígitos separados um do outro por três espaços cada. Por exemplo, se o usuário 
            digitar 42339, o aplicativo deverá exibir 4 2 3 3 9 Suponha que o usuário insira 
            o número correto de dígitos. O que acontece quando você executa o aplicativo 
            e digita um número com mais de cinco dígitos? O que acontece quando você executa 
            o aplicativo e digita um número com menos de cinco dígitos? [Dica: é possível 
            fazer este exercício com as técnicas que você aprendeu neste capítulo. Você precisará 
            usar as operações de divisão e resto para "selecionar" cada dígito.]
            Autor: Pedro Filho, 22/07/2021
        */
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria variáveis
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int valor;

            // entrada de dados
            Write( "Digite um inteiro de 5 digitos:" );
            valor = int.Parse(ReadLine());

            // se o valor maior ou igual a 1000 e menor ou igual a 99999
            if( valor >= 10000 )
            {
                if( valor <= 99999 )
                {
                    // calcular
                    num1 = valor / 10000;
                    num2 = valor % 10000 / 1000;
                    num3 = valor % 1000 / 100;
                    num4 = valor % 100 / 10;
                    num5 = valor % 10;

                    Console.WriteLine($"{num1}   {num2}   {num3}   {num4}   {num5} - Hello World!");
                } // fim if
            } // fim if

            // se valor menor que 10000 e maior que 99999
            if( valor < 10000 )
            {
                WriteLine($"{valor} Valor inválido!" );
            } // fim if
           
            // se valor menor que 10000 e maior que 99999
            if( valor > 99999 )
            {
                WriteLine($"{valor} Valor inválido!" );
            } // fim if
           
        } // fim main
    } // fim classe
} // fim name
