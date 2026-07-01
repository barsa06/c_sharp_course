//Declare three variables for Physics, Chemistry, and Mathematics marks, then calculate the total.
using System;
class Result
{
    public void Marks()
    {
        int physics= 56;
        int chemistry= 45;
        int mathematics= 65;
        int total= physics + chemistry + mathematics;
        Console.WriteLine($"The total marks of physics {physics}, chemistry {chemistry} and mathematics {mathematics} is {total}");
}
}