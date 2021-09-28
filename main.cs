using System;

class Program {
  public static void Main (string[] args) {
    
    // Declaring variables 
    
     int num1;

Console.WriteLine("Enter number:");
num1 = Convert.ToInt32(Console.ReadLine());
if (num1<=1)
{
    Console.WriteLine(num1 + " is not prime number");
}
else
{
  for (int num = 2; num <= num1 / 2; num++)
    {
  if (num1 % num == 0)
  {
   Console.WriteLine(num1 + " is not a prime number");
  return;
  }

    }
 Console.WriteLine(num1 + " is a prime number");
    
}



  }
}