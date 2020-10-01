using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine(" //============================================================================\\");
      Console.WriteLine("||-----------------------------------------------------------------------------||");
      Console.WriteLine("||--PPPPPPP---IIIIIIII--EEEEEEEE--RRRRRRR---RRRRRRR---EEEEEEEE--999---SSSSSS---||");
      Console.WriteLine("||--PP----PP-----II-----EE--------RR----RR--RR----RR--EE--------99---SS----SS--||");
      Console.WriteLine("||--PP----PP-----II-----EE--------RR----RR--RR----RR--EE--------9----SS--------||");
      Console.WriteLine("||--PPPPPPP------II-----EEEEE-----RRRRRRR---RRRRRRR---EEEEE-----------SSSSSS---||");
      Console.WriteLine("||--PP-----------II-----EE--------RR-RR-----RR-RR-----EE-------------------SS--||");
      Console.WriteLine("||--PP-----------II-----EE--------RR--RR----RR--RR----EE-------------SS----SS--||");
      Console.WriteLine("||--PP--------IIIIIIII--EEEEEEEE--RR---RR---RR---RR---EEEEEEEE--------SSSSSS---||");
      Console.WriteLine("||-----------------------------------------------------------------------------||");
      Console.WriteLine("||---------BBBBBBB-----AAAA----KK----KK--EEEEEEEE--RRRRRRR---YY----YY----------||");
      Console.WriteLine("||---------BB----BB---AA--AA---KK---KK---EE--------RR----RR---YY--YY-----------||");
      Console.WriteLine("||---------BB----BB--AA----AA--KK-KK-----EE--------RR----RR----YYYY------------||");
      Console.WriteLine("||---------BBBBBB----AAAAAAAA--KKK-------EEEEE-----RRRRRRR------YY-------------||");
      Console.WriteLine("||---------BB----BB--AA----AA--KK-KK-----EE--------RR-RR--------YY-------------||");
      Console.WriteLine("||---------BB----BB--AA----AA--KK---KK---EE--------RR--RR-------YY-------------||");
      Console.WriteLine("||---------BBBBBBB---AA----AA--KK----KK--EEEEEEEE--RR---RR------YY-------------||");
      Console.WriteLine("||-----------------------------------------------------------------------------||");
      Console.WriteLine(" \\============================================================================//");
      Console.WriteLine("");
      Console.WriteLine("=+=+=+=+=  Welcome to Pierre's Bakery!  =+=+=+=+=+=");
      Console.WriteLine("");
      Console.WriteLine(" //+====================================+\\");
      Console.WriteLine("||+---------------- MENU ---------------+||");
      Console.WriteLine("||+--Bread $5.00 ea---------------------+||");
      Console.WriteLine("||+--Bread Special: Buy 2 get 1 Free----+||");
      Console.WriteLine("||+-------------------------------------+||");
      Console.WriteLine("||+--Pastry $2.00 ea--------------------+||");
      Console.WriteLine("||+--Pastry Special: Buy 3 for $5.00----+||");
      Console.WriteLine(" \\+====================================+//");
      Console.WriteLine("");

      Bread bread = new Bread("loaf",0,0);
      Pastry pastry = new Pastry("pastry",0,0);

      for (int i = 0; i < 1;)
      {
        if (bread.Number == 0 && pastry.Number == 0)
        {
          Console.WriteLine("-------------------------");
          Console.WriteLine("Your basket has nothing in it.");
          Console.WriteLine("-------------------------");
        }
        else if (bread.Number > 0 || pastry.Number > 0)
        {
          Console.WriteLine("-------------------------");
          Console.WriteLine("Your basket has: ");
          Console.WriteLine("-----------");
          if (bread.Number > 0)
          {
            Console.WriteLine("{0} {1} of bread",bread.Number, bread.Name);
          }
          if (pastry.Number > 0)
          {
            Console.WriteLine("{0} {1} ",pastry.Number, pastry.Name);
          }
          Console.WriteLine("-------------------------");
        }

        Console.WriteLine("What would you like to order? (Bread, Pastry, Receipt, or Exit)");
        string type = Console.ReadLine().ToLower();
        Console.WriteLine("-------------------------");
        
        if (type == "bread")
        {
            if (bread.Number < 0)
            {
              Console.WriteLine("How many more loaves would you like? (if you want less use a negative number)");
            }
            else
            {
              Console.WriteLine("How many loaves would you like?");
            }
          string userB = Console.ReadLine();
          bread.Number += int.Parse(userB);
          bread.Cost = Bread.BreadCost(bread.Number);
          bread.Name = Bread.BreadName(bread.Number);
        }
        else if (type == "pastry")
        {
          if (pastry.Number < 0)
          {
            Console.WriteLine("How many more pastries would you like? (if you want less use a negative number)");
          }
          else
          {
            Console.WriteLine("How many pastries would you like?");
          }
          string userP = Console.ReadLine();
          pastry.Number += int.Parse(userP);
          pastry.Cost = Pastry.PastryCost(pastry.Number);
          pastry.Name = Pastry.PastryName(pastry.Number);
        }
        else if (type == "receipt")
        {
          int total = bread.Cost + pastry.Cost;
          decimal twt = Convert.ToDecimal(total * 1.1);
          Console.WriteLine("-------------------------");
          Console.WriteLine("-------------------------");
          Console.WriteLine("Your Total with tax is: ${0:f2}", twt);
          Console.WriteLine("-------------------------");
          Console.WriteLine("You purchased:");

          if (bread.Number > 0)
          {
            Console.WriteLine("{0} {1} of bread", bread.Number, bread.Name);
          }
          if (pastry.Number > 0)
          {
            Console.WriteLine("{0} {1}", pastry.Number, pastry.Name);
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