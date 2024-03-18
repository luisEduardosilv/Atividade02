public class Program
{
    public static void Main()
    {
        double comprimento, largura, area;
        Console.WriteLine("digite o comprimento do terreno:");
        comprimento = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("digite a largura do terreno");
        largura = Convert.ToDouble(Console.ReadLine());
        area = comprimento * largura;
        Console.WriteLine(area);
    }
}