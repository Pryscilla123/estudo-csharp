<<<<<<< HEAD
﻿using System.Globalization;

namespace aula89;

class Program
{
    static void Main(string[] args)
    {
        DateTime d1 = DateTime.Now;
        //Ano mês dia 
        DateTime d2 = new DateTime(2024, 8, 18);
        // global greenwitch utc no brasil é o utc + 3 de fuso
        DateTime d3 = new DateTime(2024, 8, 18, 11, 35, 0);
        DateTime d4 = DateTime.Today;
        DateTime d5 = DateTime.UtcNow;

        // alguns bancos usam essa configuração e o c# já aceita
        DateTime d6 = DateTime.Parse("2000-08-15");
        DateTime d7 = DateTime.Parse("18/08/2024");
        //escolher sua própria formatação
        DateTime d8 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
        DateTime d9 = DateTime.ParseExact("2000-08-15 15:05:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

        System.Console.WriteLine(d2);
        System.Console.WriteLine(d3);
        System.Console.WriteLine(d4);
        System.Console.WriteLine(d5);
        System.Console.WriteLine(d6);
        System.Console.WriteLine(d7);
        System.Console.WriteLine(d8);
        System.Console.WriteLine(d9);
        //System.Console.WriteLine(d1);
        //System.Console.WriteLine(d1.Ticks);
    }
}
=======
﻿using System.Globalization;

namespace aula89;

class Program
{
    static void Main(string[] args)
    {
        DateTime d1 = DateTime.Now;
        //Ano mês dia 
        DateTime d2 = new DateTime(2024, 8, 18);
        // global greenwitch utc no brasil é o utc + 3 de fuso
        DateTime d3 = new DateTime(2024, 8, 18, 11, 35, 0);
        DateTime d4 = DateTime.Today;
        DateTime d5 = DateTime.UtcNow;

        // alguns bancos usam essa configuração e o c# já aceita
        DateTime d6 = DateTime.Parse("2000-08-15");
        DateTime d7 = DateTime.Parse("18/08/2024");
        //escolher sua própria formatação
        DateTime d8 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
        DateTime d9 = DateTime.ParseExact("2000-08-15 15:05:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

        System.Console.WriteLine(d2);
        System.Console.WriteLine(d3);
        System.Console.WriteLine(d4);
        System.Console.WriteLine(d5);
        System.Console.WriteLine(d6);
        System.Console.WriteLine(d7);
        System.Console.WriteLine(d8);
        System.Console.WriteLine(d9);
        //System.Console.WriteLine(d1);
        //System.Console.WriteLine(d1.Ticks);
    }
}
>>>>>>> 2f54776591db587008f28ed6e6b0c338db6e9ded
