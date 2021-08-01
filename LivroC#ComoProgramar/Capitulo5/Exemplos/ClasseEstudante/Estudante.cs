using System;

class Estudante
{
    // cria propriedade nome
    public string Nome { get; set; }
    // cria variável de instância média
    private double media;

    // cria o construtor da classe
    public Estudante( string nome, double media )
    {
        Nome = nome;
        Media = media;

    } // fim construtor 

    // cria propriedade média
    public double Media
    {
        get
        {
            return media;
        } // fim get
        set
        {
            if( value > 0)
            {
                if( value <= 100 )
                {
                    media = value;
                } // fim if interno

            } // fim if externo
        } // fim set
    } // fim propriedade média

    // cria letra da nota
    public string LetraDaNota
    {
        get
        {
            // string vazia
            string LetraDaNota = string.Empty;
            if(media >= 90)
            {
                LetraDaNota = "A";
            }
            else if( media >= 80)
            {
                LetraDaNota = "B";
            }
            else if( media >= 70 )
            {
                LetraDaNota = "C";
            }
            else if( media >= 60 )
            {
                LetraDaNota = "D";
            }
            else
            {
                LetraDaNota = "F";    
            }

            // retorne a letra da nota
            return LetraDaNota;
        } // fim get
    } // fim propriedade letra da nota
    
} // fim da classe estudante
