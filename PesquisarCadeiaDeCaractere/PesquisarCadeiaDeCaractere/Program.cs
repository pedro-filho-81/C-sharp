using System;

namespace PesquisarCadeiaDeCaractere
{
    class Program
    {
        static void Main(string[] args)
        {
            // cabeçalho
            Console.WriteLine("Pesquisando se uma palavra se encontra dentre de um texto.");
            // string com o texto a ser pesquisado
            string texto = "Eu sou o texto que vai ser pesquisado";
            // imprime o testo da string
            Console.WriteLine(texto);
            // imprime a palavra a ser pesquisada
            Console.WriteLine($"Tem a palavra: texto {texto.Contains("texto")}");
            // imprime outra palavra a ser pesquisada
            Console.WriteLine($"Tem a palavra: casa {texto.Contains("casa")}");
            // pesquisa uma palavra no inicio da frase
            Console.WriteLine($"Tem a palavra Eu no inicio da frase?{texto.StartsWith("Eu")}");
            // pesquisa no fim da frase
            Console.WriteLine($"Tem a palavra adeus no fim da frase?{texto.EndsWith("adeus")}");
        }
    }
}
