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
            string nomeParaConta = ReadLine();
            // chama método ExibirConta e atribui o nome para conta
            minhaConta.Nome = nomeParaConta;

            Write( "Digite o valor do saldo: R$" );
            // cria variável para o saldoDaConta que recebe o valor do usuário
            decimal saldoDaConta = decimal.Parse(ReadLine());
            // chama o objeto minhaConta.Saldo que recebe o valor digitado
            minhaConta.Saldo = saldoDaConta;

            Write("Digite o valor do depósito R$" );
            decimal valorParaDeposito = decimal.Parse(ReadLine());
            minhaConta.Deposito(valorParaDeposito );

            // chama o método exibir conta
            ExibirConta( minhaConta );

            Console.WriteLine("Hello World!");
        } // fim main

        // cria método ExibirConta
        static void ExibirConta( Conta minhaConta )
        {
            WriteLine($"A conta de {minhaConta.Nome} com saldo de {minhaConta.Saldo:C} " + 
                        $"\nrecebeu um depósito de {minhaConta.Saldo:C}");
        } // fim método exibir conta

    } // fim classe
} // fim name
