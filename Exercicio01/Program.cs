public class Program
{
    public static void Main()
    {
        Console.Write("informe o comprimento da caixa: ");
        double comprimento = Convert.ToDouble(Console.ReadLine());
        Console.Write("informe a altura da mesma: ");
        double altura = Convert.ToDouble(Console.ReadLine());
        Console.Write("por fim, informe a largura de sua caixa: ");
        double largura = Convert.ToDouble(Console.ReadLine());
        double volume = comprimento * altura * largura;
        Console.WriteLine("o volume de sua caixa é: " + volume);
    }
}