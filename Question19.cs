//19.Calculate the Body Mass Index (BMI) using weight and height variables.
using System;
class Question19
{
    public void Bmi()
    {
        double height = 5.1;
        double weight = 60.5;
        double bmi;
        Console.WriteLine($"The height and weight of a person is {height} ft and {weight} kg.");
        bmi = weight/(Math.Pow((height*0.3048),2));
        Console.WriteLine($"Bmi is {bmi}");

    }
}