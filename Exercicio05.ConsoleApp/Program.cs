// See https://aka.ms/new-console-template for more information
using Exercicio05.ConsoleApp;

Esfera esfera = new Esfera();
esfera.raio = 12;

decimal volume = esfera.CalcularVolume();

Console.WriteLine($"O volume da esfera de raio {esfera.raio:F1} é de: {volume:F2}");