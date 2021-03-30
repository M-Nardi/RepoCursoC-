using System;
using IntroducaoDelegateBinaryOperation.Services;

namespace IntroducaoDelegateBinaryOperation
{
    delegate double BinaryNumericOperation(double n1, double n2);

    delegate double OneNumericOperation(double n1);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;
            double result = op(a, b);

            OneNumericOperation pow = CalculationService.Square;
            double result2 = pow(a);

            //BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            //double result = op.Invoke(a, b);

            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}
