// See https://aka.ms/new-console-template for more information
using Exercicio02.ConsoleApp;

TemperaturaFahrenheit fahrenheit = new TemperaturaFahrenheit();
fahrenheit.graus = 100;

TemperaturaCelcius celcius = fahrenheit.ConverterParaCelcius();

Console.WriteLine($"A conversão de {fahrenheit.graus:F1} °F resultou em: {celcius.graus:F1} °C");