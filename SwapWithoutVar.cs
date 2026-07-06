//Swap the values of two variables using a third variable.
using System;
class SwapWithoutVar
{
    public void Swap()
    {
        int a = 5;
        int b= 6;

         Console.WriteLine($"The value of a is {a} and b is {b}");
         a=a+b;
         b=a-b;
         a=a-b;
         Console.WriteLine($"The value of a and b after swap is {a} and {b}");
    }
}