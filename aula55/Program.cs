<<<<<<< HEAD
﻿using System.Globalization;

namespace aula55;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("Entre os dados do produto:");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade no estoque: ");

        int quantidade = int.Parse(Console.ReadLine());
        Product p = new Product(nome, preco, quantidade);

        Console.WriteLine();
        Console.WriteLine("Dados do produto: " + p);
        Console.WriteLine();

        Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
        int qte = int.Parse(Console.ReadLine());
        p.AddProducts(qte);

        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + p);
        Console.WriteLine();

        Console.Write("Digite o número de produtos a ser removido do estoque: ");
        qte = int.Parse(Console.ReadLine());
        p.RemoveProducts(qte);

        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + p);*/

        Product p = new Product("TV", 900, 10);

        p.Name = "";

        Console.WriteLine(p.Name); 
    }
}
=======
﻿using System.Globalization;

namespace aula55;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("Entre os dados do produto:");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade no estoque: ");

        int quantidade = int.Parse(Console.ReadLine());
        Product p = new Product(nome, preco, quantidade);

        Console.WriteLine();
        Console.WriteLine("Dados do produto: " + p);
        Console.WriteLine();

        Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
        int qte = int.Parse(Console.ReadLine());
        p.AddProducts(qte);

        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + p);
        Console.WriteLine();

        Console.Write("Digite o número de produtos a ser removido do estoque: ");
        qte = int.Parse(Console.ReadLine());
        p.RemoveProducts(qte);

        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + p);*/

        Product p = new Product("TV", 900, 10);

        p.Name = "";

        Console.WriteLine(p.Name); 
    }
}
>>>>>>> 2f54776591db587008f28ed6e6b0c338db6e9ded
