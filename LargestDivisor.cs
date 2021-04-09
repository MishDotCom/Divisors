using System;

public class CMMDC
{
static void Main()
{
    Console.WriteLine("Enter num1: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter num2: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    
    while(num1 != num2)
    {
        if(num1 > num2)
        {
            num1 -= num2;
        }
        if(num2 > num1)
        {
            num2 -= num1;
        }
    }
    
    Console.WriteLine(num1);
}
}
