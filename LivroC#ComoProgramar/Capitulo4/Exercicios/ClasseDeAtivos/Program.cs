using System;
using static System.Console;

namespace ClasseDeAtivos
{
    class Program
    {
        /*
            4.11 (Classe de ativo) Crie uma classe chamada Ativo que inclui três informações 
            como variáveis de instância ou propriedades autoimplementadas - nome do ativo 
            (tipo string), valor do ativo (tipo decimal) e taxa de depreciação (tipo decimal). 
            Sua classe deve ter um construtor que inicializa os três valores. 
            Fornece uma propriedade com um acessador get e set para quaisquer variáveis de instância. 
            Se o valor do ativo ou a taxa de depreciação for negativa, o acessador set deve deixar 
            a variável de instância inalterada. Escreva um aplicativo de teste denominado AssetTest 
            que demonstra os recursos da classe Asset. Crie dois objetos Ativos e exiba a quantidade 
            de depreciação de cada objeto e seu valor depreciado. Em seguida, aumente o valor de cada 
            ativo em 5% e exiba o valor de depreciação de cada ativo e seu valor depreciado.
        */
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria o objeto da classe Ativo
            Ativo meuAtivo = new Ativo( "Pedro", 5000, 5 );

            // calcular depreciação
            decimal depreciacaoAnual = meuAtivo.CalcularDepreciacao(5000, 5);
            decimal depreciacaoMensal = depreciacaoAnual / 12;
            

            // mostrar resultado
            WriteLine($"Valor da depreciação anual = {depreciacaoAnual:c}" );
            WriteLine($"Valor da depriação mensal = {depreciacaoMensal:c}" );

            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim name
