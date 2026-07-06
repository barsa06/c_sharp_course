//11.Store the price and quantity of three products and calculate the total bill.
using System;
class Bill11
{
    public void TotalBill()
    {
        int monitorp=10000;
        int monitorq=4;
        int mousep=700;
        int mouseq=10;
        int keyboardp=1250;
        int keyboardq= 12;
        int bill;

         Console.WriteLine($"The price of monitor and quantity is {monitorp} and {monitorq}");
         Console.WriteLine($"The price of mouse and quantity is {mousep} and {mouseq}");
         Console.WriteLine($"The price of keyboard and quantity is {keyboardp} and {keyboardq}");

         bill=(monitorp*monitorq)+(mousep*mouseq)+(keyboardp*keyboardq);
         Console.WriteLine($"The total bill is {bill}");
    }
}