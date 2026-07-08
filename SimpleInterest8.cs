//8.Declare variables for principal, rate, and time, then calculate simple interest.
using System;
class SimpleInterest8
{
    public void SI()
    {
        double principal = 1000;
        double rate =7.5;
        double time =2.5;
        double interest;
        Console.WriteLine($"The principle, rate and time is {principal},{rate} and {time}");
        interest = (principal*rate*time)/100;
        Console.WriteLine($"Simple Interest is {interest}");
    
        

    }
}
