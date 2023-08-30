using System;
using static Exercise_4.Fraction;
namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new(2, 3);
            Fraction fraction2 = new(3, 4);

            Console.WriteLine("Fraction 1: " + fraction1);
            Console.WriteLine("Fraction 2: " + fraction2);

            Fraction additionResult = fraction1 + fraction2;
            Fraction subtractionResult = fraction1 - fraction2;
            Fraction multiplicationResult = fraction1 * fraction2;
            Fraction divisionResult = fraction1 / fraction2;

            Console.WriteLine("Addition: " + additionResult);
            Console.WriteLine("Subtraction: " + subtractionResult);
            Console.WriteLine("Multiplication: " + multiplicationResult);
            Console.WriteLine("Division: " + divisionResult);

            Console.WriteLine("Decimal value of Fraction 1: " + fraction1.ToDecimal());
            Console.WriteLine("Decimal value of Fraction 2: " + fraction2.ToDecimal());
        }
    }
}