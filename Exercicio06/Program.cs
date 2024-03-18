public class Program
{
    public static void Main()
    {
        Console.Write("informe a temperatura em graus Celsius: ");
        double tempC = Convert.ToDouble(Console.ReadLine());
        double tempF = tempC * 1.8 + 32;
        Console.WriteLine("a temperatura em graus Fahrenheit é: " + tempF.ToString() + "°");
    }
}