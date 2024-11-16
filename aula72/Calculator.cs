<<<<<<< HEAD
namespace aula72;

class Calculator {
    //parans indicam que você vai receber uma quantidade variável de parâmetros
    public static int Sum(params int[] numbers){
        int sum = 0;
        for(int i = 0; i < numbers.Length; i++) sum += numbers[i];
        return sum;
    }
=======
namespace aula72;

class Calculator {
    //parans indicam que você vai receber uma quantidade variável de parâmetros
    public static int Sum(params int[] numbers){
        int sum = 0;
        for(int i = 0; i < numbers.Length; i++) sum += numbers[i];
        return sum;
    }
>>>>>>> 2f54776591db587008f28ed6e6b0c338db6e9ded
}