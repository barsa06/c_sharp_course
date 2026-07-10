//21.Create a mini payroll calculator using variables for salary, allowances, deductions, tax, and net salary.
using System;

class Question20
{
    public void Payroll()
    {
        double salary = 50000;
        double allowances = 5000;
        double deductions = 3000;
        double tax = 4000;

        double netSalary = salary + allowances - deductions - tax;
        Console.WriteLine($"----Payroll Calculator-----");
        Console.WriteLine($"Salary {salary}");
        Console.WriteLine($"Allowances: {allowances}");
        Console.WriteLine($"Deductions: {deductions}" );
        Console.WriteLine($"Tax: {tax}");
        Console.WriteLine($"Net Salary: {netSalary}");
    }
}