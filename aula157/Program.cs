namespace aula157;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> cookies = new Dictionary<string, string>();

        cookies["user"] = "maria";
        cookies["email"] = "maria@gmail.com";
        cookies["phone"] = "156156510";

        System.Console.WriteLine(cookies["email"]);

        cookies.Remove("email");

        foreach(KeyValuePair<string, string> cookie in cookies)
        {
            System.Console.WriteLine(cookie.Key + " - " + cookie.Value);
        }
    }
}
