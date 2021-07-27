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

            // cria variáveis
            decimal ativo = 5000m;
            decimal taxa = 5;
            
            // cria o objeto da classe Ativo
            Ativo meuAtivo = new Ativo( "Pedro", ativo, taxa );
            decimal depreciacaoAnual = meuAtivo.CalcularDepreciacao(ativo, taxa);
            decimal depreciacaoMensal = depreciacaoAnual / 12;
            
            // mostrar resultado
            WriteLine($"Nome: {meuAtivo.NomeDoAtivo}");
            WriteLine($"Valor do ativo {ativo:c}");
            WriteLine($"Taxa de depreciação {taxa}%");
            WriteLine($"Valor da depreciação anual = {depreciacaoAnual:c}" );
            WriteLine($"Valor da depriação mensal = {depreciacaoMensal:c}" );

            ativo = 2000m;
            taxa = 2.5m;
            // 2º objeto da classe Ativo
            Ativo meuAtivo2 = new Ativo( "Maria", ativo, taxa );

            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim name
