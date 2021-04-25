using System;
using static System.Console;

namespace Variavel
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear(); // limpa a tela

            object altura = 1.81; // atribuindo um double a um objeto
            object nome = "Pedro"; // atribuindo uma string a um objeto
            //monsta o conteúdo dos objetos
            Console.WriteLine($"{nome} tem {altura}m de altura");

            //int tamanho = nome.Length; // vai dá erro, tem que usar o Typecast
            int tamanhoDoNome = ( (string) nome ).Length; // mostra o tamanho da string
            // imprima
            WriteLine($"{nome} tem {tamanhoDoNome} letras." );

            dynamic outroNome = "Maria"; // atribuindo string a dynamic
            // usando dynamic não precisa do typecast como em object
            int tamanho2 = outroNome.Length; // mostra o tamanho do outro nome
            // imprime
            WriteLine($"{outroNome} tem {tamanho2} caracteres." );
            
            Console.WriteLine("Hello World!");
        }
    }
}
