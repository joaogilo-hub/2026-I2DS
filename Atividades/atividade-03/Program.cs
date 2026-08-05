 internal class Program
{
    private static void Main(string[] args)
    {
        string nome;
        double nota1;
        double nota2;
        double nota3;
        double math;

        Console.Write("Nome do Aluno: ");
        nome = Console.ReadLine();

        Console.Write("Nota1: ");
        nota1 = double.Parse(Console.ReadLine());

        Console.Write("Nota2: ");
        nota2 = double.Parse(Console.ReadLine());

        Console.Write("Nota3: ");
        nota3 = double.Parse(Console.ReadLine());

        math = (nota1 + nota2 + nota3) / 3;

        if (math >= 7);
    }
}