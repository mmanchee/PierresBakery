using System;
using PierresBakery;

namespace PierresBakery.Models
{
  public class Bread
  {
    public static int BreadCost(int number)
    {
      int total = number * 5;
      return total;
    }
  }
}