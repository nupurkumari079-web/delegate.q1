using System;

class Program3
{
    
    delegate void TemperatureConverter(double celsius);

    
    static void Fahrenheit(double celsius)
    {
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("Fahrenheit = " + fahrenheit);
    }

    
    static void Kelvin(double celsius)
    {
        double kelvin = celsius + 273.15;
        Console.WriteLine("Kelvin = " + kelvin);
    }

    static void Main4()
    {
        
        TemperatureConverter temp = Fahrenheit;

        
        temp += Kelvin;

        
        temp(25);
    }
}
