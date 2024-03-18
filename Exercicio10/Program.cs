public class Program
{
    public static void Main()
    {
        double nota1, nota2, peso1, peso2, media;
        Console.WriteLine("digite a sua nota na primeira prova");
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("digite o peso da primeira prova");
        peso1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("digite a sua nota na segunda prova");
        nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("digite o peso da segunda prova");
        peso2 = Convert.ToDouble(Console.ReadLine());

        media = ((peso1 * nota1) + (peso2 * nota2)) / (peso1 + peso2);
        Console.WriteLine(media);
    }
}