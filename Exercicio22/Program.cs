public class Program
{
    public static void Main()
    {
        int a, b, c;
        Console.WriteLine("Digite o primeiro numero:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero:");
        b = Convert.ToInt32(Console.ReadLine());
        if (a == b)
        {
            c = a + b;
            Console.WriteLine("Somados: " + c);
        }
        else
        {
            c = a * b;
            Console.WriteLine("multiplicados: " + c);
        }
    }
}