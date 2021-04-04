using System; // biblioteca obrigatória

class Conta // cria a classe Conta
{
    // cria propriedade do tipo string Nome
    public string Nome { get; set; }
    
    // cria variável privada do tipo decimal de nome saldo 
    private decimal saldo;

    // cria construtor que tem de ter o mesmo nome da classe
    public Conta( string nome, decimal saldoInicial )
    {
        // atribui a variável nome a propriedade Nome
        this.Nome = nome;
        // atribui a variável saldoInicial a propriedade Saldo
        this.Saldo = saldoInicial;
    } // fim construtos

    // cria a propriedade Saldo
    public decimal Saldo
    {
        // que
        get
        {
            // retorna o valor a variável saldo
            return saldo;
        } // fim get
        // cria set
        private set
        {
            // verifica se o valor informado no construtor é maior que zero
            if( value > 0.0M ) // se verdade
            {
                // a variável saldo recebe o valor
                saldo = value;
            } // fim if
            
        } // fim set
    } // fim propriedade Saldo

    // cria o método Depósito
    public void Deposito( decimal depositoNaConta )
    {
        // se o depóeiso for maior que zero
        if( depositoNaConta > 0.0M)
        {
            // saldo soma mais depósito na conta
            saldo += depositoNaConta;
        } // fim if
    } // fim método Deposito

    //cria o método para retirara dinheiro da conta
    public void Retiradas( decimal saques )
    {
        // verificar se tem saldo na conta
        if( saldo > 0.0M) // se verdade
        {
            // o valor é subitraido do saldo
            saldo -= saques;
        } // fim if
        
    } // fim método Retirada
    
} // fim classe
