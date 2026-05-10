namespace Exercicio02.ConsoleApp;

public class TemperaturaFahrenheit
{
    public decimal graus;

    public TemperaturaCelcius ConverterParaCelcius()
    {
        TemperaturaCelcius celcius = new TemperaturaCelcius();
        celcius.graus = (graus - 32) * 5 / 9;

        return celcius;
    }
}
