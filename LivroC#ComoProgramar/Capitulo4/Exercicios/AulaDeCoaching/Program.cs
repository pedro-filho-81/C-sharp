using System;
using static System.Console;

namespace AulaDeCoaching
{
    class Program
    {
        /*
            4.12 (Aula de Coaching) Crie uma classe chamada Coaching que inclui 
            quatro informações como propriedades autoimplementadas - 
            o tipo de coaching (tipo string), o número de jogadores (tipo int), 
            tempos de aula (tipo string) e encargos (tipo decimal) . 
            Sua classe deve ter um construtor que inicializa as quatro propriedades 
            automáticas e assume que os valores fornecidos estão corretos. 
            Fornece um método DisplayDetails que exibe o tipo de treinador, número 
            de jogadores, tempo da classe e encargos (em $) separados por guias. 
            Escreva um aplicativo de teste denominado CoachingTest que demonstra 
            as capacidades da classe de Coaching.
            Autor: Pedro Filho, 28/07/2021
        */
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria o objeto da classe Coaching
            Coaching meuTreino = new Coaching("Pedro", 10, "5", 25);

            // cham o método dysplay
            meuTreino.DisplayDetails();

            // cria objeto 2 da classe Coaching
            Coaching meuTreino1 = new Coaching("Maria",5, "3 ", 52 );
            meuTreino1.DisplayDetails();
            
            Console.WriteLine("Precione qualquer tecla para terminar.");
            ReadKey(); // pausa o programa
        } // fim main
    } // fim classe
} // fim name
