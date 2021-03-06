using System;

namespace CadeiaDeCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            // variáveis
            string fristFriend = "Pedro";
            string secoundFriend = "Cleonice";
            
            // imprima
            Console.WriteLine($"My friends are {fristFriend} and {secoundFriend}");
            
            // a propriedade length mostra o tamanho da string
            Console.WriteLine($"The name {fristFriend} has {fristFriend.Length} lettres.");
            Console.WriteLine($"The name {secoundFriend} has {secoundFriend.Length} lettres.");

            Console.ReadLine();
        }
    }
}
