using System;
using PierresBakery;

namespace PierresBakery.Models
{
  public class Bread
  {
    public static int BreadCost(int number)
    {
      int total = 0;
      int newNum = number%3;
      total += newNum * 5;
      int by3 = number/3;
      total += by3 * 10;
      
      return total;
    }
  }
}