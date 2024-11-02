using System;

public class Fractions
{
    private int numerator;
    private int denominator;

    public Fractions(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero.");

        this.numerator = numerator;
        this.denominator = denominator;
        Simplify();
    }

    public Fractions Add(Fractions other)
    {
        int newNumerator = numerator * other.denominator + other.numerator * denominator;
        int newDenominator = denominator * other.denominator;
        return new Fractions(newNumerator, newDenominator);
    }

    public Fractions Subtract(Fractions other)
    {
        int newNumerator = numerator * other.denominator - other.numerator * denominator;
        int newDenominator = denominator * other.denominator;
        return new Fractions(newNumerator, newDenominator);
    }

    public Fractions Multiply(Fractions other)
    {
        int newNumerator = numerator * other.numerator;
        int newDenominator = denominator * other.denominator;
        return new Fractions(newNumerator, newDenominator);
    }

    public Fractions Divide(Fractions other)
    {
        if (other.numerator == 0)
            throw new DivideByZeroException("Cannot divide by a fraction with zero numerator.");

        int newNumerator = numerator * other.denominator;
        int newDenominator = denominator * other.numerator;
        return new Fractions(newNumerator, newDenominator);
    }

    private void Simplify()
    {
        int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
        numerator /= gcd;
        denominator /= gcd;
    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public override string ToString()
    {
        return $"{numerator}/{denominator}";
    }

    public static void Main(string[] args)
    {
        Fractions fraction1 = new Fractions(1, 2);
        Fractions fraction2 = new Fractions(3, 4);

        Console.WriteLine("Fraction 1: " + fraction1);
        Console.WriteLine("Fraction 2: " + fraction2);

        Console.WriteLine("Sum: " + fraction1.Add(fraction2));
        Console.WriteLine("Difference: " + fraction1.Subtract(fraction2));
        Console.WriteLine("Product: " + fraction1.Multiply(fraction2));
        Console.WriteLine("Quotient: " + fraction1.Divide(fraction2));
    }
}
                