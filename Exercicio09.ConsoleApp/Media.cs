namespace Exercicio09.ConsoleApp;

public class Media
{
    public double nota1;
    public double nota2;

    public double CalcularMediaHarmonica()
    {
        return 2 / ((1 / nota1) + (1 / nota2));
    }
}
