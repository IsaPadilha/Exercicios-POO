namespace Exercicio08.ConsoleApp;

public class LataOleo
{
    public decimal raio;
    public decimal altura;

    public decimal CalcularVolume()
    {
        decimal pi = 3.14m;

        return pi * raio * raio * altura;
    }
}
