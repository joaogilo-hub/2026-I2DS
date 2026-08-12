internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHO COM FILAS ===");

        // 1 - criar uma nova fila vazia 
        Queue<string> filaBanco = new Queue<string>();

        // 2 - Adicionar elementos na fila
        filaBanco.Enqueue("Zuleika");        //0
        filaBanco.Enqueue("Asdrubal");       //1
        filaBanco.Enqueue("pafuncio");       //2
        filaBanco.Enqueue("Epaminondas");    //3

        // 3 - percorrer elementos  de uma fila
        Console.WriteLine();
        foreach (var pessoa in filaBanco);
        {
            Console.WriteLine(pessoa);
        }
    }
}