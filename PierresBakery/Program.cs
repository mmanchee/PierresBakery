using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      for (int i = 0; i < 1;)
      {
        Console.WriteLine("What would you like to order? (Bread, Pastry, Receipt, or Exit)");
        string type = Console.ReadLine().ToLower();
        if (type == "bread")
        {
          Console.WriteLine("How many loaves would you like?");
          string userB = Console.ReadLine();
          int bread = int.Parse(userB);
        }
        else if (type == "pastry")
        {
          Console.WriteLine("How many pastries would you like?");
          string userP = Console.ReadLine();
          int pastry = int.Parse(userP);
        }
        else if (type == "receipt")
        {
          // total function
          i++;
        }
        else if (type == "exit")
        {
          i++;
        }
        else
        {
          Console.WriteLine("Input not vaild, please try again.");
        }
      }
      
    }
  }
}