public class Program
{
    public static void Main()
    {
        int num, soma = 0, n1 = 1, n2 = 1;
        int i = 0;
        Console.WriteLine("digite o numero");
        num = Convert.ToInt32(Console.ReadLine());

        do
        {
            i+=soma;
            soma = n1 + n2;
            n2 = n1;
            n1 = soma;
            Console.WriteLine(soma);
        } while (i < num);
    }
}