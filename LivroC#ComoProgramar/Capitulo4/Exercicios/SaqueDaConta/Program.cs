using System;
using static System.Console;

namespace SaqueDaConta
{
    class Program
    {
        /*
            3.11 (Classe Account modificada) Modifique a classe Account (Figura 3.8) 
            para fornecer um método chamado withdraw que retira dinheiro de uma Account. 
            Assegure que o valor de débito não exceda o saldo de Account. Se exceder, 
            o saldo deve ser deixado inalterado  e o método deve imprimir uma mensagem que 
            indica "Withdrawal amount exceeded account balance" [Valor de débito  excedeu 
            o saldo da conta]. Modifique a classe AccountTest (Figura 3.9) para testar o método
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 77). Edição do Kindle. 
        */
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria o objeto da classe conta e atribui valores
            Conta minhaConta = new Conta("Pedro", 1000m);
            Conta minhaConta1 = new Conta("Cleonice", -7.25m );

            // cabeçalho
            // cor do fundo
            BackgroundColor = ConsoleColor.DarkBlue;
            // cor das letras
            ForegroundColor = ConsoleColor.White;
            // texto
            WriteLine("LISTA DE CLIENTES E SEUS SALDOS" );
            // retorna a cor anterior
            ResetColor();

            // mostra conta inicial
            WriteLine($"{minhaConta.NomeDaConta} Saldo inicial {minhaConta.Saldo:C}");
            WriteLine($"{minhaConta1.NomeDaConta} Saldo inicial {minhaConta1.Saldo:C}\n");

            // entrada de dados
            Write("Digite o nome do cliente:" );
            string nomeDoCliente = ReadLine();
            minhaConta.NomeDaConta = nomeDoCliente;
            
            Write("Digite o valor do depósito: " );
            decimal valorDoDeposito = decimal.Parse(ReadLine());
            minhaConta.Deposito(valorDoDeposito);
            
            // mostra resultado
            // mostra conta 
            WriteLine($"{minhaConta.NomeDaConta} Saldo inicial {minhaConta.Saldo:C}");

            // entrada de dados
            Write("\nDigite o nome do cliente1:" );
            string nomeDoCliente1 = ReadLine();
            minhaConta1.NomeDaConta = nomeDoCliente1;
           
            Write("Digite o valor do depósito: " );
            decimal valorDoDeposito1 = decimal.Parse(ReadLine());
            minhaConta1.Deposito(valorDoDeposito1);

            // mostra resultado
            // mostra conta 
            WriteLine($"{minhaConta1.NomeDaConta} Saldo inicial {minhaConta1.Saldo:C}\n");

            // entrada do saque
            Write("Informe o nome da conta: ");
            nomeDoCliente = ReadLine();
            minhaConta.NomeDaConta = nomeDoCliente;

            Write("Informe o valor do saque: " );
            decimal valorDoSaque = decimal.Parse(ReadLine());
            minhaConta1.Saque(valorDoSaque);

            // mostra resultado
            // mostra conta 
            WriteLine($"{minhaConta1.NomeDaConta} Saque {valorDoSaque:C} Saldo {minhaConta1.Saldo:C}\n");
            
            Console.WriteLine("Precione qualquer tecla para terminar.");
            ReadKey(); // pausa o programa
        } // fim main
    } // fim classe
} // fim namespace
