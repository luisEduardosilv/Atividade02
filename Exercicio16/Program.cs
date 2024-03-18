public class Program
{
    public static void Main()
    {
        Console.WriteLine("informe seu salario:");
        decimal salarioInicial = Convert.ToDecimal(Console.ReadLine());
        decimal salarioAumento = salarioInicial + (salarioInicial * 0.15M);
        decimal salarioFinal = salarioAumento - (salarioAumento * 0.08M);
        Console.WriteLine($"o seu salário inicial é de R${salarioInicial}. após o aumento ele é de R${salarioAumento}. e após o desconto ele é de R${salarioFinal}.");
    }
}