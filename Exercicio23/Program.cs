public class Program
{
    public static void Main()
    {
        int i = 3, soma = 0;
        while (i <= 500)
        {
            if (i % 3 == 0)
            {
                soma += i;
            }
            i += 2;
        }
        Console.WriteLine(soma);
    }
}