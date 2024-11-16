namespace aula90;

class Program
{
    static void Main(string[] args)
    {
        //datetime é data e timespan é intervalo
        /*TimeSpan t1 = new TimeSpan(0, 1, 30);
        TimeSpan t2 = new TimeSpan(900000000L);
        //construtor com dia
        TimeSpan t3 = new TimeSpan(1, 2, 11, 21);
        TimeSpan t4 = new TimeSpan(1, 2, 11, 21, 321);
        TimeSpan t5 = TimeSpan.FromDays(1.5);

        Console.WriteLine(t1);
        Console.WriteLine(t2);
        Console.WriteLine(t3);
        Console.WriteLine(t4);
        Console.WriteLine(t5); 
        System.Console.WriteLine(t1.Ticks);*/
        TimeSpan t1 = TimeSpan.MaxValue;
        TimeSpan t2 = TimeSpan.MinValue;
        TimeSpan t3 = TimeSpan.Zero;
        TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);

        TimeSpan t5 = new TimeSpan(1, 30, 10);
        TimeSpan t6 = new TimeSpan(0, 10, 5);

        TimeSpan sum = t5.Add(t6);
        TimeSpan sub = t5.Subtract(t6);
        TimeSpan mult = t6.Multiply(2.0);
        TimeSpan div = t6.Divide(2);

        System.Console.WriteLine("Soma {0} + {1}: {2}", t5, t6, sum);
        System.Console.WriteLine("Subtração {0} + {1}: {2}", t5, t6, sub);
        System.Console.WriteLine("Tempo {0} multiplicado por 2: {1}", t6, mult);
        System.Console.WriteLine("Tempo {0} dividido por 2: {1}", t6, div);

        System.Console.WriteLine(t1);
        System.Console.WriteLine(t2);
        System.Console.WriteLine(t3);
        System.Console.WriteLine("Days: {0}", t4.Days);
        Console.WriteLine("Hours: " + t4.Hours);
        Console.WriteLine("Minutes: " + t4.Minutes);
        Console.WriteLine("Milliseconds: " + t4.Milliseconds);
        Console.WriteLine("Seconds: " + t4.Seconds);
        Console.WriteLine("Ticks: " + t4.Ticks);

        Console.WriteLine("TotalDays: " + t4.TotalDays);
        Console.WriteLine("TotalHours: " + t4.TotalHours);
        Console.WriteLine("TotalMinutes: " + t4.TotalMinutes);
        Console.WriteLine("TotalSeconds: " + t4.TotalSeconds);
        Console.WriteLine("TotalMilliseconds: " + t4.TotalMilliseconds);
    }
}
