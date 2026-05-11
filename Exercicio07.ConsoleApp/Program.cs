// See https://aka.ms/new-console-template for more information
using Exercicio07.ConsoleApp;

Console.WriteLine("Informe o salário base: ");
double salarioBase = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o total de vendas: ");
double totalVendas = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o percentual de comissão: ");
double percentualComissao = Convert.ToDouble(Console.ReadLine());

Salario s = new Salario();
s.salarioBase = salarioBase;
s.totalVendas = totalVendas;
s.percentualComissao = percentualComissao;

double salarioTotal = s.CalcularSalarioTotal();

Console.WriteLine($"O salário total é de: R${salarioTotal:F2}");
Console.ReadLine();

