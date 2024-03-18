public class Program
{
    public static void Main()
    {
        Console.WriteLine("Por favor, informe a quilometragem inicial do seu veículo:");
        double kmInicial = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("informe a quilometragem final do veículo:");
        double kmFinal = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("informe o consumo de combustível total do veículo:");
        double consumo = Convert.ToDouble(Console.ReadLine());

        double kmConsumo = (kmFinal - kmInicial) / consumo;
        Console.WriteLine("o consumo de combustível por km do carro foi de: " + kmConsumo);
    }
}