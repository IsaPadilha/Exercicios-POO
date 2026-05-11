// See https://aka.ms/new-console-template for more information
using Exercicio09.ConsoleApp;

Console.WriteLine("Digite a primeira nota: ");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

Media m = new Media();
m.nota1 = nota1;
m.nota2 = nota2;

double media = m.CalcularMediaHarmonica();

Console.WriteLine($"A média harmônica do aluno é: {media:F2}");
