using System;

class Conta
{
    // cria a variável de instância
    private decimal saldo;

    // cria a propriedade nome
    public string Nome { get; }
    
    // cria construtor
    public Conta( string nome, decimal saldo )
    {
        // atribuindo às variáveis
        Nome = nome;
        Saldo = saldo;

    } // fim construtor

   // criando a propriedade Saldo
   public decimal Saldo
   {
       get
       {
           // retorne o valor do saldo
           return saldo;
       } // fim get
       set
       {
           // se o valor for maior que zero
           if( value > 0 )
           {
               // atribuir o valor ao saldo
               saldo = value;
           } // fim if
       } // fim set

   } // fim propriedade saldo
} // fim classe conta
