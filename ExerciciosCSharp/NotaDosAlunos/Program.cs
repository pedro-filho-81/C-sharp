using System;

namespace NotaDosAlunos
{
    class Program
    {
        static void Main(String[] args)
        {
            // cria variáveis
            int somaNotas = 0;
            int contaNotas = 0;
            int notaA = 0;
            int notaB = 0;
            int notaC = 0;
            int notaD = 0;
            int notaF = 0;
            int notas = 0;

             Console.Clear(); // limpa a tela

            // entrada de dados
            Console.WriteLine("Digite as notas entre 0 - 100 [ -1 = sair ]: ");
            
            // loop para entrada das notas
            while( notas != -1 )
            {
                // recebe as notas do usuário
                notas = int.Parse(Console.ReadLine()); //
                
                // se notas maior que zero e menot que 100
                if( notas > 0 && notas <= 100 )
                {
                    somaNotas += notas; // soma as notas digitadas
                    ++contaNotas; // contas quantas notas foram digitadas

                    // switch divide as notas por 10
                    switch( notas / 10 )
                    {
                        case 9: // case nota entre 90
                        case 10: // e 100 inclusive 
                            ++notaA; // incrementa nota A
                            break;  // sai do switch

                        case 8: // caso nata entre 80 e 89
                            ++notaB;
                            break;

                        case 7: // caso nota entre 70 e 79
                            ++notaC;                            
                            break;

                        case 6: // caso nota entre 60 e 69
                            ++notaD;
                            break;

                        default: // caso nota abaixo de 60    
                            ++notaF;
                            break;
                            
                    } // fim switch
                } // fim if

            } // fim while

            // cabeçalho
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine( "Relatório das notas: ");
            Console.ResetColor();
            
            // se a soma das notas diferente de zero
            if( somaNotas != 0 ) 
            {
                // calcular a média das notas
                double mediaDasNotas = (double) somaNotas / contaNotas;

                // mostra resultado
                System.Console.WriteLine($"Foram cadastradas {contaNotas} notas, total = {somaNotas}");
                System.Console.WriteLine($"Média da turma {mediaDasNotas:N2}");
                System.Console.WriteLine($"Números de alunos e suas notas.\n" + 
                    $"A: {notaA}\n" + 
                    $"B: {notaB}\n" +
                    $"C: {notaC}\n" +
                    $"D: {notaD}\n" +
                    $"F: {notaF}\n" );

            } // fim while
        } // fim main
    } // fim classe
} // namespace