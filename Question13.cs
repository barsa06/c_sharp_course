//13.Store a student's information (Name, Roll No, Faculty, GPA) and display it in a formatted report.
using System;
class Question13
{
    public void Document()
    {
        String name = "Barsha";
        int roll = 2;
        String faculty ="Computer engineering";
        float GPA = 3.54f;

        Console.WriteLine("-------Marksheet----------");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Roll no. {roll}");
        Console.WriteLine($"Faculty: {faculty}");
        Console.WriteLine($"GPA: {GPA}");
        
        

    }
}