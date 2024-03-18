public class Program
{
    public static void Main()
    {
        Console.Write("informe a temperatura em graus fahrenheit: ");
        double tempf = Convert.ToDouble(Console.ReadLine());
        double tempc = (tempf - 32) / 1.8;
        Console.WriteLine("a temperatura em graus Celsius é: " + tempc.ToString() + "°");
    }
}