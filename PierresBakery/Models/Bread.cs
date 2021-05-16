using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadQty { get; set; }

    public Bread(int breadQty)
    {
      BreadQty = breadQty;
    }
    public int CalculateBreadPrice()
    {
      if (this.BreadQty % 3 == 0)
      {
        int totalBreadPrice = (BreadQty - (BreadQty / 3)) * 5;
        return totalBreadPrice;
      }
      else
      {
        return BreadQty * 5;
      }
    }
  }
}