// See https://aka.ms/new-console-template for more information
using Exercicio06.ConsoleApp;

TemperaturaCelcius celcius = new TemperaturaCelcius();

Console.WriteLine("Digite a temperatura °C que deseja converter: ");
celcius.graus = Convert.ToDecimal(Console.ReadLine());

TemperaturaFahrenheit fahrenheit = celcius.ConverterParaFahrenheit();

Console.WriteLine($"A conversão de {celcius.graus:F1} °C resultou em: {fahrenheit.graus:F1} °F");