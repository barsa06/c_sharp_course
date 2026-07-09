//14.Calculate compound interest using variables.
using System;
class Question14
{
    public void CInterest()
    {
        double principal = 1000;
        double rate =7.5;
        double time =2.5;
        double ci;
        Console.WriteLine("-----Compound Interest(*annually*)-----");
        Console.WriteLine($"The principle, rate and time is {principal},{rate} and {time}");
        ci = principal * Math.Pow(1 + rate, time);
        
        Console.WriteLine($"Compund interest:{ci}");
    }
}