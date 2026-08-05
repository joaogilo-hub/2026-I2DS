 internal class Program
{
    private static void Main(string[] args)
    {
        double num1;
        double num2;
        double math;

        Console.Write("Número 1: ");
        num1 = double.Parse(Console.ReadLine());       
        Console.Write("Número 2: ");
        num2 = double.Parse(Console.ReadLine());       

        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("1 - Divisão");


        Console.Write("Opção: ");
        int opcao = int.Parse(Console.ReadLine());
        

}