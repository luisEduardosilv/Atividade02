public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o seu peso");
        double peso = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a sua altura");
        double altura = Convert.ToDouble(Console.ReadLine());
        double imc = peso / (altura * altura);
        if (imc < 18.5)
        {
            Console.WriteLine($"Abaixo do peso (IMC:{imc})");
        }
        else if (imc >= 18.5 && imc < 25)
        {
            Console.WriteLine($"Peso normal (IMC:{imc})");
        }
        else if (imc >= 25 && imc <= 30)
        {
            Console.WriteLine($"acima do peso (IMC:{imc})");
        }
        else
        {
            Console.WriteLine($"obeso (IMC:{imc})");
        }
    }
}