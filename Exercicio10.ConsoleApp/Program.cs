// See https://aka.ms/new-console-template for more information
using Exercicio10.ConsoleApp;

Console.WriteLine("Digite a primeira nota: ");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o peso da primeira prova: ");
int peso1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o peso da segunda prova: ");
int peso2 = Convert.ToInt32(Console.ReadLine());

MediaPonderada mp = new MediaPonderada();
mp.nota1 = nota1;
mp.peso1 = peso1;
mp.nota2 = nota2;
mp.peso2 = peso2;

double media = mp.CalcularMediaPonderada();

Console.WriteLine($"A média ponderada do aluno é: {media:F2}");
