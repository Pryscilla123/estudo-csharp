<<<<<<< HEAD
﻿using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace aula76;

class Program
{
    static void Main(string[] args)
    {
        /*List<string> list = new List<string>();

        List<string> list2 = new List<string>{"Maria", "Alex"};
        Console.WriteLine("Hello, World!");*/

        List<string> list = new List<string>();

        list.Add("Alex");
        list.Add("Maria");
        list.Add("Ana");
        list.Insert(1, "Marco");

        foreach (string s in list){
            Console.WriteLine(s);
        }
        System.Console.WriteLine("List count: {0}", list.Count);

        //Lambda como se lê x tal que a primeira posição de x seja igual a A.
        System.Console.WriteLine("Finding the first name that starts with an a: {0}", list.Find(x => x[0] == 'A'));
        System.Console.WriteLine("Finding the last name that starts with an a: {0}", list.FindLast(Test));

        System.Console.WriteLine("Finding the index of the first name that starts with an a: {0}", list.FindIndex(Test));
        System.Console.WriteLine("Finding the index of the last name that starts with an a: {0}", list.FindLastIndex(Test));

        // mesma coisa que o filter
        List<string> list2 = list.FindAll(x => x.Length == 5);

        foreach (string s in list2) System.Console.WriteLine(s);

        System.Console.WriteLine();

        list.Remove("Alex");
        foreach(string s in list) System.Console.WriteLine(s);

        list.RemoveAll(x=> x[0] == 'M');
        System.Console.WriteLine();

        foreach(string s in list) System.Console.WriteLine(s);

        list.Add("Bruna");

        list.RemoveAt(0);

        System.Console.WriteLine();
        foreach(string s in list) System.Console.WriteLine(s);

        list.Add("Gabriel");
        list.Add("Gabriela");

        list.RemoveRange(0, 2);

        System.Console.WriteLine();
        foreach(string s in list) System.Console.WriteLine(s);
    }

    static bool Test(string s){
        return s[0] == 'A';
    }
}
=======
﻿using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace aula76;

class Program
{
    static void Main(string[] args)
    {
        /*List<string> list = new List<string>();

        List<string> list2 = new List<string>{"Maria", "Alex"};
        Console.WriteLine("Hello, World!");*/

        List<string> list = new List<string>();

        list.Add("Alex");
        list.Add("Maria");
        list.Add("Ana");
        list.Insert(1, "Marco");

        foreach (string s in list){
            Console.WriteLine(s);
        }
        System.Console.WriteLine("List count: {0}", list.Count);

        //Lambda como se lê x tal que a primeira posição de x seja igual a A.
        System.Console.WriteLine("Finding the first name that starts with an a: {0}", list.Find(x => x[0] == 'A'));
        System.Console.WriteLine("Finding the last name that starts with an a: {0}", list.FindLast(Test));

        System.Console.WriteLine("Finding the index of the first name that starts with an a: {0}", list.FindIndex(Test));
        System.Console.WriteLine("Finding the index of the last name that starts with an a: {0}", list.FindLastIndex(Test));

        // mesma coisa que o filter
        List<string> list2 = list.FindAll(x => x.Length == 5);

        foreach (string s in list2) System.Console.WriteLine(s);

        System.Console.WriteLine();

        list.Remove("Alex");
        foreach(string s in list) System.Console.WriteLine(s);

        list.RemoveAll(x=> x[0] == 'M');
        System.Console.WriteLine();

        foreach(string s in list) System.Console.WriteLine(s);

        list.Add("Bruna");

        list.RemoveAt(0);

        System.Console.WriteLine();
        foreach(string s in list) System.Console.WriteLine(s);

        list.Add("Gabriel");
        list.Add("Gabriela");

        list.RemoveRange(0, 2);

        System.Console.WriteLine();
        foreach(string s in list) System.Console.WriteLine(s);
    }

    static bool Test(string s){
        return s[0] == 'A';
    }
}
>>>>>>> 2f54776591db587008f28ed6e6b0c338db6e9ded
