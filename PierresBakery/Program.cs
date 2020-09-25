using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      int[] numArray = {0,0,0,0}; //{Loaves,Bread$,Parties,Pastry$}
      string[] wordArray = {"loaf", "pastry"};
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("----- MENU -----");
      Console.WriteLine("Bread $5.00 ea");
      Console.WriteLine("Bread Special: Buy 2 get 1 Free");
      Console.WriteLine("-------------------------");
      Console.WriteLine("Pastry $2.00 ea");
      Console.WriteLine("Pastry Special: Buy 3 for $5.00");
      Console.WriteLine("-------------------------");


      for (int i = 0; i < 1;)
      {
        if (numArray[0] == 0 && numArray[2] == 0)
        {
          Console.WriteLine("Your basket has nothing in it.");
          Console.WriteLine("-------------------------");
        }
        else if (numArray[0] > 0 || numArray[2] > 0)
        {
          Console.WriteLine("Your basket has: ");
          Console.WriteLine("-------------------------");
          if (numArray[0] > 0)
          {
            Console.WriteLine("{0} {1} of bread",numArray[0], wordArray[0]);
          }
          if (numArray[2] > 0)
          {
            Console.WriteLine("{0} {1} ",numArray[2], wordArray[1]);
          }
          Console.WriteLine("-------------------------");
        }
        Console.WriteLine("What would you like to order? (Bread, Pastry, Receipt, or Exit)");
        string type = Console.ReadLine().ToLower();
        if (type == "bread")
        {
            if (numArray[0] < 0)
            {
              Console.WriteLine("How many more loaves would you like? (if you want less use a negative number)");
            }
            else
            {
              Console.WriteLine("How many loaves would you like?");
            }
          string userB = Console.ReadLine();
          numArray[0] += int.Parse(userB);
          numArray[1] = Bread.BreadCost(numArray[0]);
          wordArray[0] = Bread.BreadName(numArray[0]);
        }
        else if (type == "pastry")
        {
          if (numArray[2] < 0)
          {
            Console.WriteLine("How many more pastries would you like? (if you want less use a negative number)");
          }
          else
          {
            Console.WriteLine("How many pastries would you like?");
          }
          string userP = Console.ReadLine();
          numArray[2] += int.Parse(userP);
          numArray[3] = Pastry.PastryCost(numArray[2]);
          wordArray[1] = Pastry.PastryName(numArray[2]);
        }
        else if (type == "receipt")
        {
          int total = numArray[1] + numArray[3];
          decimal twt = Convert.ToDecimal(total * 1.1);
          Console.WriteLine("Your Total with tax is: ${0:f2}", twt);
          Console.WriteLine("-------------------------");
          Console.WriteLine("You purchased:");

          if (numArray[0] > 0)
          {
            Console.WriteLine("{0} {1} of bread", numArray[0], wordArray[0]);
          }
          if (numArray[2] > 0)
          {
            Console.WriteLine("{0} {1}", numArray[2], wordArray[1]);
          }
          Console.WriteLine("-------------------------");
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