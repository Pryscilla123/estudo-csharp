namespace aula73;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b;
        // o a não vai mudar de valor, no caso assim como c, dentro da função vai ser uma variável temporária
        // caso eu queria que mude o valor eu preciso passar a referência da variável (local de memória/ponteiro)
        // no caso de c# ref
        //Calculator.Triple(ref a);

        Calculator.Triple(a, out b);
        System.Console.WriteLine(b);

    }
}
