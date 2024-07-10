internal class Program
{
    private static void Main(string[] args)
    {   
        //imprime o texto entre "" no terminal ao iniciar o projeto
        Console.WriteLine("Entre com seu nome completo");

        //Será solicitado que digite seu nome e ele será armazenado na varivel Nome
        string Nome = Console.ReadLine();

        //imprime o texto entre "" no terminal ao iniciar o projeto
        Console.WriteLine("Quantos quartos tem na sua casa?");

        //Será solicitado que digite o numero de quartos que existem em sua casa  e ele será armazenado na varivel Quartos
        int Quartos = int.Parse(Console.ReadLine());

         //imprime o texto entre "" no terminal ao iniciar o projeto
        Console.WriteLine("Entre com o preço de um produto");

        //Será solicitado que digite o preço do produto comprado e ele será armazenado na varivel Preco
        double Preco = double.Parse(Console.ReadLine());

             //imprime o texto entre "" no terminal ao iniciar o projeto
            Console.WriteLine("Entre seu último nome, idade e altura");

        //Um vetor utilizado para imprimir e inserir informações de texto e númericas no terminal, cada informação será inserida em uma variavel e após isso as informações serão impressas no terminal em sequencia
        string[] vet = Console.ReadLine().Split(' ');
        string Sobrenome = vet[0];
        int idade = int.Parse(vet[1]);
        double altura = double.Parse(vet[2]);

    //Aqui será impresso todas as informações inseridas no terminal, em formato de lista
     Console.WriteLine(); // usado para saltar uma linha, por isso não contém informação
     Console.WriteLine(Nome);
     Console.WriteLine(Quartos);
     Console.WriteLine(Preco);
     Console.WriteLine(Sobrenome);
     Console.WriteLine(idade);
     Console.WriteLine(altura);



            Console.ReadLine();
        
    }
}
