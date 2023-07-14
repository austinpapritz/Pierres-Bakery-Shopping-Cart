using Bakery.Models;
using System;
using System.Collections.Generic;

class Program
{
    static void Main() 
    {
      // Welcome.
      Console.WriteLine("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*  ____  _                    _       ____        _                    ~");
      Console.WriteLine("~ |  _ \\(_) ___ _ __ _ __ ___( )___  | __ )  __ _| | _____ _ __ _   _  *");
      Console.WriteLine("* | |_) | |/ _ \\ '__| '__/ _ \\// __| |  _ \\ / _` | |/ / _ \\ '__| | | | ~");
      Console.WriteLine("~ |  __/| |  __/ |  | | |  __/ \\__ \\ | |_) | (_| |   <  __/ |  | |_| | *");
      Console.WriteLine("* |_|   |_|\\___|_|  |_|  \\___| |___/ |____/ \\__,_|_|\\_\\___|_|   \\__, | ~");
      Console.WriteLine("~                                                               |___/  *");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~");
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Bread = $5 (BUY 2 GET 1 FREE!!)");
      Console.WriteLine("Pastries = $2 (BUY 3 GET 1 FREE!!)");

      // Take bread order.
      Console.WriteLine("\nHow many loaves of bread do you want?");
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
      Console.WriteLine("\nHere are your totals");
      Console.WriteLine($"Bread ({numOfLoaves}) = ${breadTotal}");
      Console.WriteLine($"Pastry ({numOfPastries}) = ${pastryTotal}");
      Console.WriteLine($"Your total = ${breadTotal + pastryTotal}");
    }
}
