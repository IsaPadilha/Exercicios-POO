namespace Exercicio03.ConsoleApp;

public class Cilindro
{
    public decimal raio;
    public decimal altura;

    public decimal CalcularVolume()
    {
        decimal pi = 3.14m;

        return pi * raio * raio * altura;
    }
}
