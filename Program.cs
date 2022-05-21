using ProjetoCsharp.Classes;

public class Program
{
    static void Main(string[] args)
    {
        MeuMetodo("Meu C# é legal");
        string retornoNome = RetornaNome("Vitoria", "Vicentin");
        Console.WriteLine(retornoNome);
        CallProduct(1, "Razer", 299.00);
    }

    static void CallProduct(int id, string name, double price)
    {
        Product product = new Product(id, name, price);

        Console.WriteLine(product.Id);
        Console.WriteLine(product.Name);
        Console.WriteLine(product.Price);
    }
    static void MeuMetodo(string frase)
    {
        Console.WriteLine(frase);
    }

    // Parametro Opcional sempre por ultimo
    static string RetornaNome(string nome, string sobrenome, int idade = 18
    )
    {
        string retorno = nome + " " + sobrenome + " tem " + idade.ToString() + " anos";
        return retorno;
    }
}