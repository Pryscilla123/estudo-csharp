using aula165.Services;

namespace aula165;

class Program
{
    delegate double BinaryNumericOperation(double n1, double n2);
    delegate void VoidOperation(double n1, double n2);
    static void Main(string[] args)
    {
        double a = 10;
        double b = 12;

        BinaryNumericOperation op = CalculationService.Sum;
        VoidOperation vp = CalculationService.ShowMax;
        vp += CalculationService.ShowSum;

        double result = op(a, b);

        //System.Console.WriteLine(result);
        vp(a, b);
    }
}
