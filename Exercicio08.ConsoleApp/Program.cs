// See https://aka.ms/new-console-template for more information
using Exercicio08.ConsoleApp;

LataOleo lataOleo = new LataOleo();

Console.WriteLine("Digite o valor do raio: ");
lataOleo.raio = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a altura: ");
lataOleo.altura = Convert.ToDecimal(Console.ReadLine());

decimal volume = lataOleo.CalcularVolume();

Console.WriteLine($"O volume da lata de óleo é de: {volume:F2}");


