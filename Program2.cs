using System;

class Programm
{
    
    delegate void StudentDelegate(string name, int marks);

    
    static void DisplayDetails(string name, int marks)
    {
        Console.WriteLine("Student Name = " + name);
        Console.WriteLine("Marks = " + marks);
    }

    
    static void CheckResult(string name, int marks)
    {
        if (marks >= 40)
            Console.WriteLine("Result = Pass");
        else
            Console.WriteLine("Result = Fail");
    }

    static void Main2()
    {
        
        StudentDelegate del = DisplayDetails;

        
        del("Nupur", 75);

       
        del += CheckResult;

        
        del("Nupur", 75);
    }
}