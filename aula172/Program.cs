using aula172.Entities;
using System.Linq;

namespace aula172;

class Program
{
    static void Main(string[] args)
    {
        Category c1 = new Category() {
            Id = 1,
            Name = "Tools",
            Tier = 2
        };

        Category c2 = new Category() {
            Id = 1,
            Name = "Computers",
            Tier = 1
        };

        Category c3 = new Category() {
            Id = 1,
            Name = "Electronics",
            Tier = 1
        };

        List<Product> products = new List<Product>() 
        {
            new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
            new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
            new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
            new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
            new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
            new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
            new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
            new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
            new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
            new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
            new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
        };

        //var r1 = products.Where(p => (p.Price < 900) && (p.Category.Tier == 1));
        var r1 = from p in products where p.Category.Tier == 1 && p.Price < 900.00 select p;

        Print("TIER 1 AND PRICE < 900: ", r1);

        //var r2 = products.Where(x => x.Category.Name.Equals("Tools")).Select(x => x.Name);
        var r2 = from p in products where p.Category.Name == "Tools" select p.Name;

        Print("NAME OF PRODUCTS FROM TOOLS", r2);

        //var r3 = products.Where(x => x.Name[0] == 'C').Select(x => new {x.Name, x.Price, CategoryName = x.Category.Name});

        var r3 = from p in products where p.Name[0] == 'C' select new {p.Name, p.Price, CategoryName = p.Category.Name };

        Print("NAME STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

        //var r4 = products.Where(x => x.Category.Tier == 1).OrderBy(x => x.Price).ThenBy(x => x.Name);
        //aqui inverte a ordem do orderby
        var r4 = from p in products where p.Category.Tier == 1 orderby p.Name orderby p.Price select p;

        Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

        var r5 = r4.Skip(2).Take(4);

        Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

        var r6 = products.First();
        System.Console.WriteLine("First test1: " + r6);

        var r7 = products.Where(x => x.Price > 3000.00).FirstOrDefault();
        System.Console.WriteLine("First or default test2: " + r7);

        var r8 = products.Where(x => x.Id == 3).SingleOrDefault();
        System.Console.WriteLine("Single or default test1: " + r8);

        var r9 = products.Where(x => x.Id == 30).SingleOrDefault();
        System.Console.WriteLine("Single or default test1: " + r9);
    }

    static void Print<T>(string message, IEnumerable<T> collection)
    {
        System.Console.WriteLine(message);
        foreach(T obj in collection)
        {
            System.Console.WriteLine(obj);
        }
        System.Console.WriteLine();
    }
}
