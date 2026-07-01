//Swap the values of two variables using a third variable.
using System;
class Swapping
{
    public void Swap()
    {
        int a = 5;
        int b= 6;
        int c;

         Console.WriteLine($"The value of a is {a} and b is {b}");
         c=b;
         b=a;
         a=c;
         Console.WriteLine($"The value of a and b after swap is {a} and {b}");
    }
}