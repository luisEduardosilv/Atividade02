public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o valor de A");
        double A = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor de B");
        double B = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor de C");
        double C = Convert.ToDouble(Console.ReadLine());
        if (A + B < C)
        {
            Console.WriteLine($"{A} + {B} < {C}");
        }
        else
        {
            Console.WriteLine($"{A} + {B} >= {C}");
        }
    }
}