using System; // biblioteca obrigatória

// cria a classe fatura
class Fatura
{
    // variáveis de instância
    private string numeroDaFatura;
    private string descricaoDoProduto;
    private int quantidadeComprada;
    private decimal preco;

    // cria o construtor
    public Fatura( string numero, string descricao, int quantidade, decimal preco )
    {
        this.numeroDaFatura = numero;
        this.descricaoDoProduto = descricao;
        this.quantidadeComprada = quantidade;
        this.preco = preco;

    } // fim construtor

    // propriedade para o número da fatura
    public string NumeroDaFatura 
    { 
        get
        {
            return numeroDaFatura;
        } // fim get
        set
        {

        } // fim set
    } // fim propriedade 

    public string Descricao
    {
        get
        {
            return descricaoDoProduto;
        } // fim get
    
    } // fim propriedade Produto

    // cria a propriedade Quantidade
    public int Quantidade
    {
        get
        {
            return quantidadeComprada;
        } // fim get
    
    } // fim propriedade Quantidade

    // cria propriedade Preco
    public decimal Preco
    {
        get
        {
            return preco;
        } // fim get

    } // fim propriedade Preco

    // cria o método valor da fatura
    public decimal ValorDaFatura()
    {
        return Quantidade * Preco;
        
    } // fim método valor da fatura

} // fim da classe Fatura