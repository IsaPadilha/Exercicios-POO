namespace Exercicio04.ConsoleApp;

public class Distancia
{
    public double kmInicial;
    public double kmFinal;
    public double combustivel;

    public double CalcularConsumo()
    {
        double distancia = kmFinal - kmInicial;
        return distancia / combustivel;
    }
}
