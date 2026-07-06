//9.Create variables for five subject marks and calculate the average.
using System;
class Average9
{
    public void Avg()
    {
        int math=63;
        int physics=54;
        int chemistry=52;
        int social=63;
        int english = 69;
        double average;
        Console.WriteLine($"Maths={math},Physics={physics},Chemistry={chemistry},Social={social},English={english}");

        average = (math+physics+chemistry+english+social)/5;
        Console.WriteLine($"The average of all subjects is {average}");
    }
}