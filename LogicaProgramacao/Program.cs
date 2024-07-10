internal class Program
{
    private static void Main(string[] args)
    {   
        Console.WriteLine("Entre com seu nome completo");
        string Nome = Console.ReadLine();

        Console.WriteLine("Quantos quartos tem na sua casa?");
        int Quartos = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com o preço de um produto");
        double Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre seu último nome, idade e altura");

        string[] vet = Console.ReadLine().Split(' ');
        string Sobrenome = vet[0];
        int idade = int.Parse(vet[1]);
        double altura = double.Parse(vet[2]);

     Console.WriteLine();
     Console.WriteLine(Nome);
     Console.WriteLine(Quartos);
     Console.WriteLine(Preco);
     Console.WriteLine(Sobrenome);
     Console.WriteLine(idade);
     Console.WriteLine(altura);



            Console.ReadLine();
        
    }
}