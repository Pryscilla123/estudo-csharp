using extensionmethods.Extentions;

namespace extensionmethods;

class Program
{
    static void Main(string[] args)
    {
        DateTime dt = new DateTime(2024, 10, 30, 0, 0, 0);
        System.Console.WriteLine(dt.ElapsedTime());

        string s1 = "Good morning dear students!";
        System.Console.WriteLine(s1.Cut(10));
    }
}
