using System;
using PierresBakery;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public static int PastryCost(int number)
    {
      int total = 0;
      int newNum = number%3;
      total += newNum * 2;
      int by3 = number/3;
      total += by3 * 5;
      
      return total;
    }
  }
}