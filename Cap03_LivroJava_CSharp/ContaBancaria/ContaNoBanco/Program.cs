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
            // mostra resultado inicial
            Console.WriteLine($"O nome da conta é {minhaConta1.Nome} " + 
                $"meu saldo inicial é {minhaConta1.Saldo:C}");
            Console.WriteLine($"O nome da conta é {minhaConta2.Nome} " + 
                $"meu saldo é {minhaConta2.Saldo:C}");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            // entrada de dados
            System.Console.WriteLine("Entre com o nome da conta1: ");
            // cria a variável do tipo string que recebe do usuário o nome da conta1
            string nomeDaConta1 = Console.ReadLine();
            // chama o objeto e atribui o nome da conta1
            minhaConta1.Nome = nomeDaConta1;

            // entrada de dados do depósito da conta 1
            System.Console.WriteLine("Entre com o valor de depóeito da conta 1: " );
            // cria a variável que recebe do usuário da conta 1
            decimal depositoDaConta1 = decimal.Parse(Console.ReadLine());
            // chama o método Depósito da classe Conta e atribui o valor do depósito
            minhaConta1.Deposito( depositoDaConta1 );
            

            // entrada de dados
            System.Console.WriteLine("Entre com o nome da conta2: ");
            // cria a variável que recebe do usuário o nome da conta1
            string nomeDaConta2 = Console.ReadLine();
            // chama o objeto e atribui o nome da conta1
            minhaConta2.Nome = nomeDaConta2;

            // entrada de dados do depósito da conta 1
            System.Console.WriteLine("Entre com o valor de depóeito da conta2: " );
            // cria a variável que recebe do usuário da conta 1
            decimal depositoDaConta2 = decimal.Parse(Console.ReadLine());
            // chama o método Depósito da classe Conta e atribui o valor do depósito
            minhaConta2.Deposito( depositoDaConta2 );
            Console.ResetColor(); // retorna para as cores originais
            
            // mostra o nome e o valor da conta1
            System.Console.WriteLine($"O nome e da conta1 é {minhaConta1.Nome} " +
                $"com o saldo de {minhaConta1.Saldo:C}");

            // mostra o nome e o valor da conta1
            System.Console.WriteLine($"O nome e da conta2 é {minhaConta2.Nome} " +
                $"com o saldo de {minhaConta2.Saldo:C}");

            // faze um saque na conta
            System.Console.WriteLine($"Informe o valor do saque da conta 1:");
            // cria a variável do saque
            decimal saqueDaConta1 = decimal.Parse(Console.ReadLine());
            // chama o método retiradas para fazer um saque na conta 1
            minhaConta1.Retiradas( saqueDaConta1 );

            // mostra a conta 1 depois da retirada
            // mostra o nome e o valor da conta1
            System.Console.WriteLine($"Na conta de {minhaConta1.Nome}, " +
                $"foi realizado um saque de {saqueDaConta1:C}, " +
                $"saldo atual {minhaConta1.Saldo:C}");

            System.Console.WriteLine("Precione qualquer tecla para encerrar.Pedro");
            Console.ReadLine(); // pausa programa
            Console.Clear(); // limpa a tela

        } // fim main
    } // fm classe
} // fim namespace
