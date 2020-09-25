using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      int[] userArray = {0,0,0,0}; //{Loaves,Bread$,Parties,Pastry$}
      int number = 0;
      Console.WriteLine("Welcome to Pierre's Bakery!");
      for (int i = 0; i < 1;)
      {
        Console.WriteLine("What would you like to order? (Bread, Pastry, Receipt, or Exit)");
        string type = Console.ReadLine().ToLower();
        if (type == "bread")
        {
            if (userArray[0] < 0)
            {
              Console.WriteLine("How many more loaves would you like? (if you want less use a negative number)");
            }
            else
            {
              Console.WriteLine("How many loaves would you like?");
            }
          string userB = Console.ReadLine();
          int bread = int.Parse(userB);
          number = bread + userArray[0];
          userArray[3] = Bread.BreadCost(number);
        }
        else if (type == "pastry")
        {
          if (type == "bread")
        {
            if (userArray[2] < 0)
            {
              Console.WriteLine("How many more loaves would you like? (if you want less use a negative number)");
            }
            else
            {
              Console.WriteLine("How many loaves would you like?");
            }
          string userP = Console.ReadLine();
          int pastry = int.Parse(userP);
          number = pastry + userArray[2];
          userArray[3] = Pastry.PastryCost(number);
        }
        else if (type == "receipt")
        {
          
          Console.WriteLine("Your Total with tax is: " + total);
          Console.WriteLine();
          Console.WriteLine();
          Console.WriteLine();
          Console.WriteLine();
          i++;
        }
        else if (type == "exit")
        {
          i++;
        }
        else
        {
          Console.WriteLine("Input not valid, please try again.");
        }
      }
      
    }
  }
}