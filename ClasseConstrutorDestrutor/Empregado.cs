using System;

class Empregado
{
    // construtor da classe empregado sem parâmetro
    public void ConstrutorFuncionario()
    {
        // imprime mensagem
        Console.WriteLine("Construtor padrão invocado sem parâmetro.");
    } // fim construtor

    // cria o destrutor
    ~Empregado()
    {
        Console.Write("Destrutor padrão invocado sem parâmetro");
    } // fim destrutor

} // fim classe