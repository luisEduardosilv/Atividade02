public class Program
{
    public static void Main()
    {

        Console.WriteLine("digite o valor que deseja fatorar");
        int A = Convert.ToInt32(Console.ReadLine());
        int result = 1;
        for (int i = A - 1; i >= 0; i--)
        {
            result += result * i;
        }
        Console.WriteLine(result);
    }
}