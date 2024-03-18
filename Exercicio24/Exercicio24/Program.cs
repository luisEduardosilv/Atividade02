public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o número que você quer calcular");
        int N = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <=10; i++)
        {
            int result = N * i;
            Console.WriteLine($"{i} x {N} = {result}");
        }
    }
}