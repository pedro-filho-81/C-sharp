using System;
using static System.Console;

namespace Horario
{
    class Program
    {
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            Horas horaInformada = new Horas();
            horaInformada.ConfigurarHora(12,00,00);
            horaInformada.MostraHoras();

            Console.WriteLine("Hello World!");
        }
    }
}
