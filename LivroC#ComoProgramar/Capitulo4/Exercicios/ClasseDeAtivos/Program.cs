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
            Ativo meuAtivo = new Ativo( "Pedro", 5000, 4 );

            // cria variáveis
            decimal taxaDeDepreciacao = (5000 * 4 / 100); 
            decimal valorDepreciado =  5000 - taxaDeDepreciacao;
            decimal acrescimo = (valorDepreciado * 5 / 100) + valorDepreciado ;

            WriteLine($"Nome: {meuAtivo.NomeDoAtivo}");
            WriteLine($"Valor do ativo: {meuAtivo.ValorDoAtivo:c}");
            WriteLine($"Taxa de depreciação: {meuAtivo.TaxaDaDepreciacao}%");
            WriteLine($"Valor da depreciação: {taxaDeDepreciacao:c}" );
            WriteLine($"Valor depreciado: {valorDepreciado:c}");
            WriteLine($"Acrescimo ao valor depreciado: 5%");
            WriteLine($"Valor depreciado com acrescimo: {acrescimo:c}");
            Write("Aperte qualquer tecla para encerrar: ");
            ReadKey(); // pausa

        } // fim main
    } // fim classe
} // fim name
