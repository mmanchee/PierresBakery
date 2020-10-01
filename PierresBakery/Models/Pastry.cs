namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Cost { get; set; }
    public int Number { get; set; }
    public string Name { get; set; }

    public Pastry(string name, int number, int cost)
    {
      Name = name;
      Number = number;
      Cost = cost;
    }
    public static int PastryCost(int number)
    {
      int newNum = number % 3;
      int total = newNum * 2;
      if (number > 2)
      {
        int by3 = number / 3;
        total += by3 * 5;
      } 
      
      return total;
    }
    public static string PastryName(int number)
    {
      if (number > 1)
      {
        return "pastries";
      }
      else
      {
        return "pastry";
      }
    }
  }
}