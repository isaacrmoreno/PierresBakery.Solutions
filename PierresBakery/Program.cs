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
      int intBreadInput = 0;
      try
      {
        intBreadInput = int.Parse(userBreadInput);
      }
      catch (FormatException)
      {
        Console.WriteLine("Error: Please enter a number.");
        Main();
      }
      Console.Write("How many pastry's would you like?:");
      string userPastryInput = Console.ReadLine();
      int intPastryInput = 0;
      try
      {
        intPastryInput = int.Parse(userPastryInput);
      }
      catch (FormatException)
      {
        Console.WriteLine("Error: Please enter a number.");
        Main();
      }
      Pastry newPastry = new(intPastryInput);
      Bread newBread = new(intBreadInput);
      int TotalOrderPrice = newBread.CalculateBreadPrice() + newPastry.CalculatePastryPrice();
      Console.WriteLine($"Great! Your total price will be: {TotalOrderPrice}!");
      Main();
    }
  }
}