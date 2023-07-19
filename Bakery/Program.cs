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
    int numOfLoaves;
    // User will be prompted until they enter a valid order.
    while (true)
    {
      Console.WriteLine("\nHow many loaves of bread do you want?");
      // Catch null, negative, and non-parseable values.
      try
      {
        // Null catch.
        string order = Console.ReadLine();
        if (order == null)
        {
          throw new ArgumentNullException();
        }
        // Parse order, catch negative values.
        numOfLoaves = int.Parse(order);
        if (numOfLoaves < 0)
        {
          throw new ArgumentOutOfRangeException();
        }
        // Order is valid, break the while loop.
        break;
      }
      catch (Exception)
      {
        Console.WriteLine("!!! Please enter a whole positive number !!!");
      }
    }

    // Calculate bread total.
    Bread breadOrder = new Bread(numOfLoaves);
    int breadTotal = breadOrder.TotalPriceCalc();


    // Take pastry order.
    int numOfPastries;
    // User will be prompted until they enter a valid order.
    while (true)
    {
      Console.WriteLine("\nHow many pastries do you want?");

      // Catch negative, null, and non-parseable values.
      try
      {
        // Null catch.
        string order = Console.ReadLine();
        if (order == null)
        {
          throw new ArgumentNullException();
        }
        // Parse order and catch negative values.
        numOfPastries = int.Parse(order);
        if (numOfPastries < 0)
        {
          throw new ArgumentOutOfRangeException();
        }
        // Order is valid, break the while loop.
        break;
      }
      catch (Exception)
      {
        Console.WriteLine("!!! Please enter a whole positive number !!!");

      }
    }

    // Calculate pastry total.
    Pastry pastryOrder = new Pastry(numOfPastries);
    int pastryTotal = pastryOrder.TotalPriceCalc();

    // Calculate and tell user the order total.
    Console.WriteLine("\nHere are your totals");
    Console.WriteLine($"Bread ({numOfLoaves}) = ${breadTotal}");
    Console.WriteLine($"Pastry ({numOfPastries}) = ${pastryTotal}");
    Console.WriteLine($"Your total = ${breadTotal + pastryTotal}");
  }
}
