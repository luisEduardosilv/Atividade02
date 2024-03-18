public class Program
{
    public static void Main()
    {
        double n1, n2, n3, n4, media;

        Console.WriteLine("digite a primeira nota");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("digite a segunda nota");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("digite a terceira nota");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("digite a quarta nota");
        n4 = int.Parse(Console.ReadLine());

        media = 4/((1/n1)+(1/n2)+(1/n3)+(1/n4));

        Console.WriteLine(media.ToString("N3"));
    }
}