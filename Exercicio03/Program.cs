public class Program
{
    public static void Main()
    {
        Console.WriteLine("digite o raio do seu cilindro");
        double raio = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("digite a altura do seu cilindro");
        double altura = Convert.ToDouble(Console.ReadLine());

        double volume = 3.14 * (raio * raio) * altura;
        Console.WriteLine("o volume do cilindro é: " + volume);
    }
}