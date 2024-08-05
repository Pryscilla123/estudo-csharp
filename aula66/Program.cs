namespace aula66;

class Program
{
    static void Main(string[] args)
    {
        //Structs assim como classes precisam ser inicializadas;
        //Structs são values então se duas variáveis recebem a mesma struct e só uma delas altera o valor, a outra permanece.
        //O nome de classe é como a posição de memória dela, então se duas recebem a mesma e uma delas muda a outra também muda?

        // Objetos alocados dinamicamente, quando não possuem mais referência para eles, serão desalocados pelo garbage collector
        // variáveis locais são desalocadas imediatamente assim que seu escopo local sai de execução
       Point p;
       p.X = 10;
       p.Y = 20;

       //Mesma coisa que esrever Nullable<double> x = null;
       double? x = null;
       double? y = 10.0;

       System.Console.WriteLine(x.GetValueOrDefault());
       System.Console.WriteLine(y.GetValueOrDefault());

       System.Console.WriteLine(x.ToString(), y.ToString());
       
       if (x.HasValue)
            System.Console.WriteLine(x.Value);
       else
            System.Console.WriteLine("X is null");

       if (y.HasValue)
            System.Console.WriteLine(y.Value);
       else
            System.Console.WriteLine("Y is null");
        
        // Operador de coalescência nula
        // significa que o g vai receber o z, mas se o z for nulo ele vai receber 0 (já que ele foi declarado como double e double não recebe nulo)

        double? z = null;
        double g = z ?? 0.0;

       //System.Console.WriteLine(p);
    }
}
