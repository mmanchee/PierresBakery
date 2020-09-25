using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      for (int i = 0; i < 2; i++)
      {
        Console.WriteLine("Welcome to Pierre's Bakery!");
        Console.WriteLine("What would you like to order? (Bread, Pastry, or Exit)");
        string type = Console.ReadLine().ToLower();
        if (type == "bread")
        {

        }
        else if (type == "pastry")
        {

        }
        else
        {
          i++;
        }
      }
      
    }
  }
}