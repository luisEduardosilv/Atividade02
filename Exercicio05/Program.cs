public class Program
{
    public static void Main()
    {
        double pi = Math.PI;

        Console.Write("Digite o raio da esfera: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        double volume = 4 / 3 * pi * (raio * raio * raio);

        Console.WriteLine($"O volume da esfera com raio {raio} é: {volume:F2}");
    }
}