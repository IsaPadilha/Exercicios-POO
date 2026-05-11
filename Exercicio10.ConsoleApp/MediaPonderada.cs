namespace Exercicio10.ConsoleApp;

public class MediaPonderada
{
    public double nota1;
    public int peso1;
    public double nota2;
    public int peso2;

    public double CalcularMediaPonderada()
    {
        return ((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2);
    }
}
