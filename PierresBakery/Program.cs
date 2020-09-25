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
          userArray[0] += int.Parse(userB);
          userArray[3] = Bread.BreadCost(userArray[0]);
        }
        else if (type == "pastry")
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
          userArray[2] += int.Parse(userP);
          userArray[3] = Pastry.PastryCost(userArray[2]);
        }
        else if (type == "receipt")
        {
          int bTotal = userArray[1];
          int pTotal = userArray[3];
          int total = bTotal + pTotal;
          decimal twt = Convert.ToDecimal(total * 1.1);
          Console.WriteLine("Your Total with tax is: ${0:f2}", twt);
          Console.WriteLine("You purchased:");
          if (userArray[0] > 0)
          {
            int loafNum = userArray[0];
            string loaf = "loaf";
            if (loafNum < 1)
            {
              loaf = "loaves";
            }
            Console.WriteLine("{0} {1} of bread", loafNum, loaf);
          }
          if (userArray[0] > 0)
          {
            int pastNum = userArray[0];
            string past = "pastry";
            if (pastNum < 1)
            {
              past = "pastries";
            }
            Console.WriteLine("{0} {1} of bread", pastNum, past);
          }
          
          Console.WriteLine("Thank you for your order, We hope to see you again soon!");
          i++;
        }
        else if (type == "exit")
        {
          Console.WriteLine("Thank you, Come again!");
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