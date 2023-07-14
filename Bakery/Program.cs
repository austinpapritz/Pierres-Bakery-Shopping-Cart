using Bakery.Models;
using System;
using System.Collections.Generic;

class Program
{
    static void Main() 
    {
      // Welcome.
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to Pappy's Bakery!");
      Console.WriteLine("A loaf of bread is $5, a pastry is $2!");
      Console.WriteLine("Loaves of bread are buy 2 get 1 free!");
      Console.WriteLine("Pastries are buy 3 get 1 free!");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");

      // Take bread order.
      Console.WriteLine("How many loaves of bread do you want?");
      int numOfLoaves = int.Parse(Console.ReadLine());
      // Calculate bread total.
      Bread breadOrder = new Bread(numOfLoaves);
      int breadTotal = breadOrder.BreadPriceCalc();

      // Take pastry order.
      Console.WriteLine("How many pastries do you want?");
      int numOfPastries = int.Parse(Console.ReadLine());
      // Calculate pastry total.
      Pastry pastryOrder = new Pastry(numOfPastries);
      int pastryTotal = pastryOrder.PastryPriceCalc();

      // Calculate and tell user the order total.
      Console.WriteLine("Here are your totals");
      Console.WriteLine($"Bread ({numOfLoaves}) = ${breadTotal}");
      Console.WriteLine($"Pastry ({numOfPastries}) = ${pastryTotal}");
      Console.WriteLine($"Your total = ${breadTotal + pastryTotal}");
    }
}
