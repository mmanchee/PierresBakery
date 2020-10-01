namespace PierresBakery.Models
{
  public class Bread
  {
    public int Cost { get; set; }
    public int Number { get; set; }
    public string Name { get; set; }

    public Bread(string name, int number, int cost)
    {
      Name = name;
      Number = number;
      Cost = cost;
    }
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
    public static string BreadName(int number)
    {
      if (number > 1)
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