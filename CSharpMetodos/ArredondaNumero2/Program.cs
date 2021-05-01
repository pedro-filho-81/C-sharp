using System;
using static System.Console;


namespace ArredondaNumero2
{
    class Program
    {
        /*
            6.10 (Arredondando números) Para arredondar números em casas decimais específicas, 
            utilize uma instrução como  y = Math.floor(x * 10 + 0.5)/ 10; que arredonda x para 
            a casa decimal (isto é, a primeira posição à direita do ponto de fração decimal), 
            ou  y = Math.floor(x * 100 + 0.5)/ 100;  que arredonda x para a casa centesimal 
            (isto é, a segunda posição à direita do ponto de fração decimal). 
            Escreva um aplicativo que defina  quatro métodos para arredondar um número x de 
            várias maneiras:  
            a) roundToInteger(number)  
            b) roundToTenths(number)  
            c) roundToHundredths(number)  
            d) roundToThousandths(number) 
            Para cada leitura de valor, seu programa deve exibir o valor original, o número 
            arredondado para o inteiro mais próximo, o número  arredondado para o décimo mais 
            próximo, o número arredondado para o centésimo mais próximo e o número arredondado 
            para o milésimo mais próximo. 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 187). Edição do Kindle. 
            Autor: Pedro Filho, 30/04/2021
        */
        static void Main(string[] args)
        {
            // cria variáveis
            double numero = 0;
            double inteiro = 0;
            double decimais = 0;
            double centesimos = 0;
            double milesimos = 0;

            // limpa a tela
            Clear();

            // entrada de dados
            Write("Digite um número: ");
            numero = double.Parse(ReadLine());

            // arredondar o número informado
            inteiro = ArredondarParaInteiro( numero );
            decimais = ArredondarParaDecimo( numero );
            centesimos = ArredondarParaCentesimo( numero);
            milesimos = ArredondarParaMilesimo( numero );

            // imprime resultado
            WriteLine($"O número {numero} foi arredondado para o inteiro {inteiro:N0}");
            WriteLine($"O número {numero} foi arredondado para {decimais:N2}");
            WriteLine($"O número {numero} foi arredondado para {centesimos:N3}");
            WriteLine($"O número {numero} foi arredondado para {milesimos:N4}");
            
        } // fim main

        // cria método arredondar
        public static double ArredondarParaInteiro( double numero )
        {
            // cria variável
            double arredonda = Math.Floor(numero + 0.5 );
            return arredonda;
        } // fim método


        // cria método arredondar
        public static double ArredondarParaDecimo( double numero )
        {
            // cria variável
            double arredonda = Math.Floor(numero * 10 + 0.5 ) / 10;
            return arredonda;
        } // fim método

        // cria método arredondar
        public static double ArredondarParaCentesimo( double numero )
        {
            // cria variável
            double arredonda = Math.Floor(numero * 100 + 0.5 ) / 100;
            return arredonda;
        } // fim método
        
        // cria método arredondar
        public static double ArredondarParaMilesimo( double numero )
        {
            // cria variável
            double arredonda = Math.Floor(numero * 1000 + 0.5 ) / 1000;
            return arredonda;
        } // fim método


    } // fim classe
} // fim namespace
