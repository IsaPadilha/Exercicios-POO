// See https://aka.ms/new-console-template for more information
using Exercicio04.ConsoleApp;

Console.WriteLine("Informe a quilometragem inicial do veículo: ");
double kmInicial = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a quilometragem final do veículo: ");
double kmFinal = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Em litros, informe a quantidade de combustível consumida durante a viagem: ");
double combustivel = Convert.ToDouble(Console.ReadLine());

Distancia d = new Distancia();
d.kmInicial = kmInicial;
d.kmFinal = kmFinal;
d.combustivel = combustivel;

double consumoKm = d.CalcularConsumo();

Console.WriteLine($"Você consumiu cerca de {consumoKm:F2} litros por quilômetro em sua viagem!");
