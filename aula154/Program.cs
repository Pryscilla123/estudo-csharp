namespace aula154;

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> set = new HashSet<string>();

        set.Add("Maria");
        set.Add("Alex");

        //esse método da um hashcode e depois o equals para ter certeza
        System.Console.WriteLine(set.Contains("Maria"));
    }
}
