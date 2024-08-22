namespace aula88;

class Program
{
    static void Main(string[] args)
    {
        //string é tipo classe
        string original = " abcde FGHIJ ABC abc DEFGH   ";

        string s1 = original.ToUpper();
        string s2 = original.ToLower();
        // tira os espaços na frente e atrás da string
        string s3 = original.Trim();
        int n1 = original.IndexOf("bc");
        int n2 = original.LastIndexOf("bc");

        string s4 = original.Substring(1, 3);
        string s5 = original.Substring(3);

        string s6 = original.Replace("a", "x");

        bool b1 = String.IsNullOrEmpty(original);
        bool b2 = string.IsNullOrEmpty(original);

        System.Console.WriteLine("Original: -{0}-", original);
        System.Console.WriteLine("ToUpper: -{0}-", s1);
        System.Console.WriteLine("ToLower: -{0}-", s2);
        System.Console.WriteLine("Trim: -{0}-", s3);
        System.Console.WriteLine("IndexOf(bc): {0}", n1);
        System.Console.WriteLine("LastIndexOf(bc): {0}", n2);
        System.Console.WriteLine("Substring 1 - 3: {0}", s4);
        System.Console.WriteLine("Substring 3 - : {0}", s5);
        System.Console.WriteLine("Replace a por x: {0}", s6);
        System.Console.WriteLine("A string original é nula: {0}", (b1 ? "Sim" : "Não"));
    }
}
