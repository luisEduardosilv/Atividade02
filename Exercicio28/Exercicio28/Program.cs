public class Program
{
    public static void Main()
    {
        int N = 1, i = 1;
        while (i <= 10 && N <= 10)
        {
            int result = N * i;
            Console.WriteLine($"{i} x {N} = {result}");
            i++;
            if (i == 11)
            {
                i = 1;
                N++;
            }
        }
    }
}