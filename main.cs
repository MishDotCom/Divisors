using System;
class Divisor {
  static void Main() {
      Console.WriteLine("Enter number: ");
      int num = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("The divisors of " + num + " are: ");
      Console.WriteLine();
      for(int i = 1; i <= num; i++)
      {
      if(num % i == 0)
      {
          Console.WriteLine(i);
      }
      }
      
    }
      
  }

