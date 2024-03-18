public class Program
{
    public static void Main()
    {
        double quantidade_paes, preco_pao = 0.12, quantidade_broas, preco_broas = 1.50, arrecadacao, poupanca;
        Console.WriteLine("digite a quantidade de pães vendidos: ");
        quantidade_paes = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("digite a quantidade de broas vendidas:");
        quantidade_broas = Convert.ToDouble(Console.ReadLine());
        arrecadacao = (quantidade_paes * preco_pao) + (quantidade_broas * preco_broas);
        poupanca = 0.1 * arrecadacao;
        Console.WriteLine(arrecadacao + " " + poupanca);
    }
}