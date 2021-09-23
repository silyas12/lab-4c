using System;

class Program {
  public static void Main (string[] args) {
    int remainder;
    Console.WriteLine("Enter a number.");
    int num1 = Convert.ToInt32(Console.ReadLine());

    for (int num=num1; num<=num1;num++){
      remainder = num % 2;
      if (remainder == 0)
      Console.WriteLine("The number " + num1 + " is not a prime number.");
  else
  Console.WriteLine("The number " + num1 + " is a prime number.");
      
    }
  
  } 
}