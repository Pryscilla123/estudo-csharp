using System.Reflection.Metadata;
using aula167.Entities;

namespace aula167;

class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();

        list.Add(new Product("Tv", 900.00));
        list.Add(new Product("Mouse", 50.00));
        list.Add(new Product("Tablet", 350.50));
        list.Add(new Product("HD Case", 80.90));

        //Predicate
        //list.RemoveAll(x => x.Price > 100.00);
        //list.RemoveAll(ProductTest);

        //Action
        //list.ForEach(UpdatePrice);
        //Action<Product> act = UpdatePrice;
        //list.ForEach(act);

        // o parenteses mostra que é void e é onde está a lógica
        /*Action<Product> act = p => {
            p.Price += p.Price * 0.1;
        };

        list.ForEach(act);*/
        //list.ForEach(p => {p.Price += p.Price * 0.1;});

        //func (retorna)
        List<string> altProducts = list.Select(x => x.Name.ToUpper()).ToList();

        foreach (var p in altProducts)
        {
            System.Console.WriteLine(p);
        }
    }

    public static void UpdatePrice(Product product)
    {
        product.Price += product.Price * 0.1;
    }

    public static bool ProductTest(Product p)
    {
        return p.Price >= 100.00;
    }
}
