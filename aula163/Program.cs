using aula163.Entities;

namespace aula163;

class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();

        list.Add(new Product("TV", 900.00));
        list.Add(new Product("Notebook", 1200.00));
        list.Add(new Product("Tablet", 450.00));

        //posso fazer desse jeito
        //Comparisn<Product> comp = CompareProducts;

        //da pra usar
        Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

        //da pra usar
        list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

        foreach (Product product in list)
        {
            System.Console.WriteLine(product);
        }
    }

    static int CompareProducts(Product p1, Product p2)
    {
        return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
    }
}
