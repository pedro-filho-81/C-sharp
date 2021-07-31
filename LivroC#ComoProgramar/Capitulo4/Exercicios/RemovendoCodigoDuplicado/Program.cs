using System;
using static System.Console;

namespace RemovendoCodigoDuplicado
{
    class Program
    {
        /*
            4.13 (Removendo código duplicado no método principal) Na classe AccountTest da Fig. 4.12, 
            o método Main contém seis declarações (linhas 13–14, 15–16, 26–27, 29–29, 39–40 e 41–42) 
            que cada um exibe o Nome e o Saldo de um objeto Conta. Estude essas declarações e você 
            notará que elas diferem apenas no objeto Conta que está sendo manipulado - conta1 ou conta2. 
            Neste exercício, você definirá um novo método DisplayAccount que contém uma cópia dessa 
            instrução de saída. O parâmetro do método será um objeto de conta e o método irá gerar 
            o nome e o saldo do objeto. Em seguida, você substituirá as seis instruções duplicadas 
            em Main por chamadas para DisplayAccount, passando como um argumento o objeto Account 
            específico para a saída. Modifique a classe AccountTest da Fig. 4.12 para declarar 
            o seguinte método DisplayAccount após a chave direita de fechamento de Main e antes 
            da chave direita de fechamento da classe AccountTest:
            
            static void DisplayAccount (conta accountToDisplay)
            {
                // coloque a declaração que exibe
                // nome e saldo da accountToDisplay aqui
            }

            Substitua o comentário no corpo da função de membro por uma declaração que exibe o nome e 
            o saldo da accountToDisplay. Observe que Main é um método estático. Também declaramos 
            o método DisplayAccount como um método estático. Quando Main precisa chamar outro método 
            na mesma classe sem primeiro criar um objeto dessa classe, o outro método também deve ser 
            declarado estático.
        */
        // Pedro Filho 29/07/2021

        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria o objeto minhaConta para classe Conta
            Conta minhaConta = new Conta();

            // entrada de dados
            Write( "Digite o nome da conta: ");
            // o usuário deve digitar o que se pede
            string nomeParaConta = ReadLine();
            // o objeto da classe minhaConta atribui a string digitada a propriedade Nome
            minhaConta.Nome = nomeParaConta;

            Write( "Digite o valor do saldo: R$" );
            // cria variável para o saldoDaConta que recebe o valor do usuário
            decimal saldoDaConta = decimal.Parse(ReadLine());
            // chama o objeto minhaConta.Saldo que recebe o valor digitado
            minhaConta.SaldoDaConta = saldoDaConta;

            Write("Digite o valor do depósito R$" );
            decimal valorParaDeposito = decimal.Parse(ReadLine());
            // se o valor digitado for maior que zero
            if( valorParaDeposito > 0.0m )
            {
                // o objeto da classe Conta atribui o valor a propriedade ValorDoDeposito
                minhaConta.ValorDoDeposito = valorParaDeposito;
            } // fim if

            Write("Digite o valor do saque R$" );
            decimal valorParaSaque = decimal.Parse(ReadLine());
            if( valorParaSaque > 0.0m )
            {
                minhaConta.ValorDoSaque = valorParaSaque;
            } // fim if

            // chama o método exibir conta que recebe o objeto da classe Conta => minhaConta
            ExibirConta( minhaConta );

            Console.WriteLine("Hello World!");
        } // fim main

        // cria método ExibirConta
        static void ExibirConta( Conta minhaConta )
        {
            // variáveis
            decimal saldoInicial = minhaConta.SaldoDaConta - minhaConta.ValorDoDeposito + minhaConta.ValorDoSaque;

            WriteLine("\nEXTRATO PARA SIMPLES CONFERÊNCIA");
            WriteLine($"A conta {minhaConta.Nome}" +
                        $"\nSaldo inicial {saldoInicial:C}" +
                        $"\nrecebeu um depósito no valor de {minhaConta.ValorDoDeposito:C} " +
                        $"\nSaldo atual {saldoInicial + minhaConta.ValorDoDeposito:C}" +
                        $"\nteve um saque no valor de {minhaConta.ValorDoSaque:C}" +
                        $"\nSaldo atual {minhaConta.SaldoDaConta:C}" );
        } // fim método exibir conta

    } // fim classe
} // fim name
