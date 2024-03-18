public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o primeiro valor");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o terceiro valor");
        int n3 = Convert.ToInt32(Console.ReadLine());

        int[] num = { n1, n2, n3 };
        Array.Sort(num);
        Array.Reverse(num);

        Console.WriteLine($"os números em ordem decrescente são: {num[0]}, {num[1]}, {num[2]}");
    }
}