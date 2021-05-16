using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryQty { get; set; }

    public Pastry(int pastryQty)
    {
      PastryQty = pastryQty;
    }

    public int CalculatePastryPrice()
    {
      if (this.PastryQty % 3 == 0)
      {
        int numOfDiscounts = PastryQty / 3;

        int totalPastryPrice = (PastryQty * 2) - numOfDiscounts;
        return totalPastryPrice;
      }
      else
      {
        return PastryQty * 2;
      }
    }
  }
}