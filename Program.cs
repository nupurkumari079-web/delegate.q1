using System;

class Program
{
    
    delegate void Calculate(int a, int b);

    
    static void Sum(int a, int b)
    {
        int result = a + b;
        Console.WriteLine("Sum = " + result);
    }

    static void Main1()
    {
        
        Calculate del = Sum;

      
        del(10, 20);
    }
}
