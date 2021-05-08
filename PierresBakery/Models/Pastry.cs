using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public static int PastryQty { get; set; }

    public Pastry(int pastryQty)
    {
      PastryQty = pastryQty;
    }

    public static int CalculatePastryPrice(int PastryQty)
    {
      if (PastryQty % 3 == 0)
      {
        int numOfDiscounts = (PastryQty / 3);

        int totalPastryPrice = ((PastryQty * 2) - numOfDiscounts);
        return totalPastryPrice;
      }
      else
      {
        return PastryQty * 2;
      }
    }
  }
}