namespace aula75;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string[] vect = new string[] { "Maria", "Bob", "Alex"};

        foreach (string obj in vect){
            System.Console.WriteLine(obj);
        }
    }
}
