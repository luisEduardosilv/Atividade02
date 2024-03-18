public class Program
{
    public static void Main()
    {
        decimal salarioTotal, salarioBase, totalVendas, comissao;

        Console.WriteLine("digite o seu salário base:");
        salarioBase = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("digite o total de vendas:");
        totalVendas = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("digite o percentual da comissão");
        comissao = Convert.ToDecimal(Console.ReadLine());

        comissao = comissao/100;

        salarioTotal = salarioBase + (totalVendas * comissao);

        Console.WriteLine(salarioTotal);
    }
}