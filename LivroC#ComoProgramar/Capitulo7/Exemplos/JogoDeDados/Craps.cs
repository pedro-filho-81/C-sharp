using System;

class Craps
{
    // cria o objeto randon
    private static Random numeroAleatorio = new Random();

    // cria o enumerador
    private enum Status { CONTINUI, VENCEU, PERDEU };

    private enum NomeDosDados
    {
        OlhoDaCobra = 2,
        Tres = 3,
        Sete = 7,
        Onze = 11,
        Doze = 12

    } // fim enum

} // fim classe