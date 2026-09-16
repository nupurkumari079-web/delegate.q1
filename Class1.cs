using System;

class calculator

{
    // Delegate
    delegate void Calculator(int a, int b);

    static void Addition(int a, int b)
    {
        Console.WriteLine("Addition = " + (a + b));
    }

    static void Subtraction(int a, int b)
    {
        Console.WriteLine("Subtraction = " + (a - b));
    }

    static void Multiplication(int a, int b)
    {
        Console.WriteLine("Multiplication = " + (a * b));
    }

    static void Division(int a, int b)
    {
        Console.WriteLine("Division = " + ((double)a / b));
    }

    static void Main3()
    {
        Calculator calc = Addition;

        
        calc += Subtraction;
        calc += Multiplication;
        calc += Division;

        
        calc(20, 5);
    }
}