using System;

namespace PierresBakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("   🍞 Welcome to Pierres Bakery! 🥧    ");
      Console.WriteLine("~~~~~~~~~~~~~~~~~MENU:~~~~~~~~~~~~~~~~");
      Console.WriteLine("Bread $5 - Special: Buy 2, get 1 free!");
      Console.WriteLine("Pastry $2 - Special: Buy 3 for $5!");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.Write("How many loafs of bread would you you like?:");
      string userBreadInput = Console.ReadLine();
      int intBreadInput = int.Parse(userBreadInput);
      Console.Write("How many pastry's would you like?:");
      string userPastryInput = Console.ReadLine();
      int intPastryInput = int.Parse(userPastryInput);
      int TotalOrderPrice = Bread.CalculateBreadPrice(intBreadInput) + Pastry.CalculatePastryPrice(intPastryInput);
      Console.WriteLine($"Great! Your total price will be: {TotalOrderPrice}!");
      Main();
    }
  }
}