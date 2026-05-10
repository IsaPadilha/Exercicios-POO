// See https://aka.ms/new-console-template for more information
using Exercicio03.ConsoleApp;

Cilindro cilindro = new Cilindro();
cilindro.raio = 5;
cilindro.altura = 15;

decimal volume = cilindro.CalcularVolume();

Console.WriteLine($"O volume do cilindro de raio {cilindro.raio:F1} e altura {cilindro.altura:F1} é: {volume:F2}");
