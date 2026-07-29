internal class Program
{
    private static void Main(string[] args)
    {
      //
      /*Comentaris de Linhas
    /*        Comentario de Bloco ou
        Comentario de Várias Linhas
     */

        // Escreve uma Linha de Texto na tela 
        Console.WriteLine("programacao Orienta a Objetos\n");

        Console.WriteLine("Abstracao - 1 pilar da POO");

        /* criar um classe em C# 
            A Classe deve ser declareda fora do bloco de programa
        */

        /* criar um objeto apartir de uma classe */

        Pet pet1 = new Pet();
        pet1.Nome = "Totó";
        pet1.tipo = "Cachorro";
        pet1.idade = 3;
        pet1.MostrarNome();

        Pet pet2 = new Pet();
        pet2.Nome = "Mingau";
        pet2.tipo = "Gato";
        pet2.idade = 8;
        pet2.MostrarNome();

    } 
    public class Pet // Nome da classe sempre inicia com letras MAISCULAS
    {
        // Declaracão dos Atributos 
        public string Nome;
        public string tipo;
        public int idade;

        //Declaracão dos Métodos
        public void MostrarNome()
        {
            Console.WriteLine("meu nome é" + this.Nome);
        }

    
    }
}
