//12.Declare variables for employee name, basic salary, bonus, and tax, then calculate the net salary.
using System;
class Question12
{
    public void Salary()
    {
       String name= "Barsha";
       int salary= 25000;
       double bonus = 2500.80;
       double tax=7;
       double netSalary;
       Console.WriteLine($"The name of employee is {name} having salary {salary} with {bonus} bonus and {tax} percent tax.");
        netSalary = salary +bonus-((tax/100)*salary);

        Console.WriteLine($"The net salary of {name } is {netSalary}");
    }
}