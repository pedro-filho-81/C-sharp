using System;
using static System.Console;

namespace SobrecargaDeConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria o objeto hora para a classe tempo2
            var horario = new Tempo2(); // 00:00:00
            var horario1 = new Tempo2(2); // 02:00:00
            var horario2 = new Tempo2(21, 34 ); // 21:34:00
            var horario3 = new Tempo2(12, 25, 42); //12:25:42
            var horario4 = new Tempo2(horario3); // 12:25:42

            // imprime resultado
            WriteLine("Horário padrão:");
            WriteLine($"{horario.HorarioUniversal()}");
            WriteLine($"{horario.ToString()}\n");

            // imprime hora específica
            WriteLine("Hora específica, minutos e segundos padrão.");
            WriteLine($"{horario1.HorarioUniversal()}");
            WriteLine($"{horario1.ToString()}");

            // imprime hora e minutos expecíficos
            WriteLine("Hora e minutos específicos, segundos padrão:");
            WriteLine($"{horario2.HorarioUniversal()}");
            WriteLine($"{horario2.ToString()}");

            // imprime hora, minutos e segundos específicos
            WriteLine("Hora, minutos e segundos específicos:");
            WriteLine($"{horario3.HorarioUniversal()}");
            WriteLine($"{horario3.ToString()}");

            // imprime o horário normal
            WriteLine("Horário padrão específico:");
            WriteLine($"{horario4.HorarioUniversal()}");
            WriteLine($"{horario4.ToString()}");
            
            Console.WriteLine("Hello World!");
        } // fim main
    } // fim classe
} // fim namespace
