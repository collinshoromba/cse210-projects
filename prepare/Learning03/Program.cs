using System;

class Program
{
    static void Main(string[] args)
    {
        
        Fraction fraction1 = new Fraction();     // 1/1
        Fraction fraction2 = new Fraction(6);    // 6/1
        Fraction fraction3 = new Fraction(6, 7); // 6/7

        //This will Display fractions using GetFractionString method
        Console.WriteLine(fraction1.GetFractionString()); // Output: 1/1
        Console.WriteLine(fraction2.GetFractionString()); // Output: 6/1
        Console.WriteLine(fraction3.GetFractionString()); // Output: 6/7

        //This Display decimal values using GetDecimalValue method
        Console.WriteLine(fraction1.GetDecimalValue()); // Output: 1.0
        Console.WriteLine(fraction2.GetDecimalValue()); // Output: 6.0
        Console.WriteLine(fraction3.GetDecimalValue()); // Output: 0.8571428571428571

        // Test getters and setters
        fraction1.SetTop(3);
        fraction1.SetBottom(4);
        Console.WriteLine(fraction1.GetFractionString()); // Output: 3/4

        // Create a fraction using the second constructor
        Fraction fraction4 = new Fraction(1);
        Console.WriteLine(fraction4.GetFractionString()); // Output: 1/1

        // Create a fraction using the third constructor
        Fraction fraction5 = new Fraction(1, 3);
        Console.WriteLine(fraction5.GetFractionString()); // Output: 1/3
        Console.WriteLine(fraction5.GetDecimalValue());   // Output: 0.3333333333333333
    }
}