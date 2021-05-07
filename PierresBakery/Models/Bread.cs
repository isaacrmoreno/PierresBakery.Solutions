using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public static int BreadQty { get; set; }

    public Bread(int breadQty)
    {
      BreadQty = breadQty;
    }

    public static int CalculateBreadPrice(int BreadQty)
    {
      if (BreadQty % 3 == 0)
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