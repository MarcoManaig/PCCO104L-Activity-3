using System;

class Program {
  public static void Main (string[] args) {

    int num, space, symbol;

    Console.WriteLine("Enter a number:");
    num = int.Parse(Console.ReadLine());
    
    for (int i = 1; i <= num; i++){
      for (space = 1; space <= num - i; space++){
        Console.WriteLine(" ");
      }
        Console.WriteLine("*");
      }
      Console.WriteLine();
    }
    Console.WriteLine("Closing program...");
  }
}