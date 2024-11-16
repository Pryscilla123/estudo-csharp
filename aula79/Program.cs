<<<<<<< HEAD
﻿namespace aula79;

class Program
{
    static void Main(string[] args)
    {
        // a virgula é para especificar que é um arranjo
        int[,] matrix = new int[2, 3];

        // quantos itens no total
        System.Console.WriteLine(matrix.Length);

        // número de linhas
        System.Console.WriteLine(matrix.Rank);

        //é a lista de posições da matriz (2, 2) pegando na posição 0 é pegando o número de linhas
        System.Console.WriteLine(matrix.GetLength(0));

        for(int i = 0; i < matrix.GetLength(0); i++){
            for(int j = 0; j < matrix.GetLength(1); j++){
                matrix[i,j] = j+1;
            }
        }

        for(int i = 0; i < matrix.GetLength(0); i++){
            for(int j = 0; j < matrix.GetLength(1); j++){
                System.Console.Write("{0} ", matrix[i, j]);
            }
            System.Console.WriteLine();
        }
    }
}
=======
﻿namespace aula79;

class Program
{
    static void Main(string[] args)
    {
        // a virgula é para especificar que é um arranjo
        int[,] matrix = new int[2, 3];

        // quantos itens no total
        System.Console.WriteLine(matrix.Length);

        // número de linhas
        System.Console.WriteLine(matrix.Rank);

        //é a lista de posições da matriz (2, 2) pegando na posição 0 é pegando o número de linhas
        System.Console.WriteLine(matrix.GetLength(0));

        for(int i = 0; i < matrix.GetLength(0); i++){
            for(int j = 0; j < matrix.GetLength(1); j++){
                matrix[i,j] = j+1;
            }
        }

        for(int i = 0; i < matrix.GetLength(0); i++){
            for(int j = 0; j < matrix.GetLength(1); j++){
                System.Console.Write("{0} ", matrix[i, j]);
            }
            System.Console.WriteLine();
        }
    }
}
>>>>>>> 2f54776591db587008f28ed6e6b0c338db6e9ded
