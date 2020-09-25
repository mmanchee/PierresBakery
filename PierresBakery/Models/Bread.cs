using System;
using PierresBakery;

namespace PierresBakery.Models
{
  public class Bread
  {
    public static int BreadCost(int number)
    {
      int newNum = number % 3;
      int total = newNum * 5;
      if (number > 2)
      {
        int by3 = number / 3;
        total += by3 * 10;
      }
      return total;
    }
    public static string BreadName(int num)
    {
      if (num > 1)
      {
        return "loaves";
      }
      else
      {
        return "loaf";
      }
    }
  }
}