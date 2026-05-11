namespace Exercicio06.ConsoleApp;

public class TemperaturaCelcius
{
    public decimal graus;

    public TemperaturaFahrenheit ConverterParaFahrenheit()
    {
        TemperaturaFahrenheit fahrenheit = new TemperaturaFahrenheit();
        fahrenheit.graus = (graus * 9 / 5) + 32;

        return fahrenheit;
    }
}
