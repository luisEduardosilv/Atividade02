public class Program
{
    public static void Main()
    {
        Console.WriteLine("digite um numero:");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num%2 == 0)
        {
            Console.WriteLine("o numero é par");
        }
        else
        {
            Console.WriteLine("o numero é ímpar");
        }
    }
}