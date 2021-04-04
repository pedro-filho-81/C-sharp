using System; // biblioteca básica 

namespace ContasBancaria // local para organizar as classes
{
    class Program // nome da classe
    {
        // método principal da classe Program
        static void Main(string[] args)
        {
            // cria o objeto minha conta da classe Conta
            // palavra chave NEW cria o objeto e atribui valor
            // minhaConta é o objeto criado
            Conta minhaConta1 = new Conta("Pedro", 50M);
            Conta minhaConta2 = new Conta("Cleonice", -7.53M);

            // cabeçalho inicial
            // COR DO FUNDO AZUL
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            // COR DAS LETRAS BRANCO
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("VALOR INICIAL");
            Console.ResetColor();

            // fim do programa
            System.Console.WriteLine("Precione qualquer tecla para encerrar.");
            Console.ReadLine(); // pausa programa
            Console.Clear(); // limpa a tela

        } // fim main
    } // fm classe
} // fim namespace
