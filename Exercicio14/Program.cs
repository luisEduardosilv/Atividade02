public class Program
{
    public static void Main()
    {
        Console.WriteLine("digite o seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("digite a sua idade:");
        int idade = Convert.ToInt32(Console.ReadLine());
        int diasDeVida = idade * 365;
        Console.WriteLine(nome + ", você já viveu " + diasDeVida + " dias");
    }
}