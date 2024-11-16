<<<<<<< HEAD
﻿namespace exerciciolista1;

class Program
{
    static void Main(string[] args)
    {
        int quartos = 0;
        
        System.Console.Write("Quantos quartos serão alugados? ");
        quartos = int.Parse(Console.ReadLine());

        Estudante[] estudantes = new Estudante[10];

        for(int i = 0; i < quartos; i++){
            string name;
            string email;
            int q = 0;

            System.Console.WriteLine("Aluguel #{0}", i+1);
            System.Console.Write("Nome: ");
            name = Console.ReadLine();

            System.Console.Write("Email: ");
            email = Console.ReadLine();

            System.Console.Write("Quarto: ");
            q = int.Parse(Console.ReadLine());

            if (estudantes[q] == null){
                estudantes[q] = new Estudante(name, email);
            }else{
                System.Console.WriteLine("Quarto preenchido, tente novamente!");
                i--;
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine("Quartos ocupados: ");
        for(int i = 0; i < estudantes.Length; i++){
            if(estudantes[i] != null){
                System.Console.WriteLine("{0}: {1}, {2}", i, estudantes[i].Name, estudantes[i].Email);
            }
        }
    }
}
=======
﻿namespace exerciciolista1;

class Program
{
    static void Main(string[] args)
    {
        int quartos = 0;
        
        System.Console.Write("Quantos quartos serão alugados? ");
        quartos = int.Parse(Console.ReadLine());

        Estudante[] estudantes = new Estudante[10];

        for(int i = 0; i < quartos; i++){
            string name;
            string email;
            int q = 0;

            System.Console.WriteLine("Aluguel #{0}", i+1);
            System.Console.Write("Nome: ");
            name = Console.ReadLine();

            System.Console.Write("Email: ");
            email = Console.ReadLine();

            System.Console.Write("Quarto: ");
            q = int.Parse(Console.ReadLine());

            if (estudantes[q] == null){
                estudantes[q] = new Estudante(name, email);
            }else{
                System.Console.WriteLine("Quarto preenchido, tente novamente!");
                i--;
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine("Quartos ocupados: ");
        for(int i = 0; i < estudantes.Length; i++){
            if(estudantes[i] != null){
                System.Console.WriteLine("{0}: {1}, {2}", i, estudantes[i].Name, estudantes[i].Email);
            }
        }
    }
}
>>>>>>> 2f54776591db587008f28ed6e6b0c338db6e9ded
