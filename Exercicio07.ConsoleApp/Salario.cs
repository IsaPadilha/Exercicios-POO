using System.Security.AccessControl;

namespace Exercicio07.ConsoleApp;

public class Salario
{
    public double salarioBase;
    public double totalVendas;
    public double percentualComissao;

    public double CalcularSalarioTotal()
    {
        double comissao = totalVendas * (percentualComissao / 100);

        return salarioBase + comissao;
    }
}
