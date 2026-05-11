namespace Exercicio05.ConsoleApp;

public class Esfera
{
    public decimal raio;

    public decimal CalcularVolume()
    {
        decimal pi = 3.14m;
        return raio * raio * raio * pi * 4 / 3;
    }
}
