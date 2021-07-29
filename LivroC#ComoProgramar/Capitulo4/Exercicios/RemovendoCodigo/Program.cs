using System;
using static System.Console;

namespace RemovendoCodigo
{
    class Program
    {
        /*
            3.15 (Removendo código duplicado no método main) Na classe AccountTest da 
            Figura 3.9, o método main contém seis instruções  (linhas 13 e 14, 15 e 16, 
            28 e 29, 30 e 31, 40 e 41 e 42 e 43) e cada uma exibe name e balance do objeto 
            Account. Estude essas instru-  ções e você perceberá que elas só diferem no 
            00objeto Account sendo manipulado — account1 ou account2. Neste exercício, 
            você  definirá um novo método displayAccount que contém uma cópia dessa 
            instrução de saída. O parâmetro do método será um objeto  Account e o método 
            irá gerar name e balance dele. Então você substituirá as seis instruções 
            duplicadas em main por chamadas para  displayAccount passando como argumento 
            o objeto específico Account para saída.  Modifique a classe AccountTest da 
            Figura 3.9 para declarar o seguinte método displayAccount após a chave direita 
            de fechamento de main e antes da chave direita de fechamento da classe AccountTest:  
            public static void displayAccount(Account Substitua o comentário no corpo do 
            1método por uma instrução que exiba name e balance de accountToDisplay.  
            Lembre-se de que main é um método static, assim pode ser chamado sem antes
             criar um objeto da classe em que é declarado. Também declaramos o método 
             displayAccount como um método static. Quando main tem de chamar outro método 
             na mesma classe  sem antes criar um objeto dela, o outro método também deve 
             ser declarado static.  Depois de concluir a declaração de displayAccount, 
             modifique main para substituir as instruções que exibem name e balance de  
             cada Account pelas chamadas para displayAccount — cada uma recebendo como 
             seu argumento o objeto account1 ou account2,  como apropriado. Então, teste 
             a classe AccountTest atualizada para garantir que ela produz a mesma saída 
             como mostrado na Figura 3.9. 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 77). Edição do Kindle. 
            Deitel, Paul; Deitel, Harvey. Java: como programar (p. 77). Edição do Kindle.
            Autor: Pedro Filho, 09/06/2021 
        */
        static void Main(string[] args)
        {
            // limpa a tela
            Clear();

            // cria o objeto da classe Conta
            Conta minhaConta = new Conta("Pedro", 1000m );
            Conta minhaConta1 = new Conta( "Maria", 500m );

            // imprime as contas
            MostrarSaldo( minhaConta );
            MostrarSaldo( minhaConta1 );

            Conta minhaConta2 = new Conta( "Ana", -75.25m );

            MostrarSaldo( minhaConta2 );
            
            Console.WriteLine("Precione qualquer tecla para terminar.");
            ReadKey(); // pausa o programa
        } // fim main

        // cria o método mostrar saldo
        public static void MostrarSaldo( Conta mostraConta )
        {
            // imprima
            WriteLine( $"A conta de {mostraConta.Nome} tem o saldo de {mostraConta.Saldo:C}" );
        } // fim método mostrar conta

    } // fim class
} // fim namespace
