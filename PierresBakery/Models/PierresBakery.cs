using System;
using System.Collections.Generic;

namespace PierresBakery
{
  public class Bread
  {
    public static int BreadPrice;
    public static int BreadQty;

    public Bread(int breadPrice, int breadQty)
    {
      BreadPrice = breadPrice;
      BreadQty = breadQty;
    }
    public static int CalculateBreadPrice()
    {

      return BreadPrice;
    }

  }
  public class Pastry
  {
    static void CalculatePastryPrice()
    {

    }
  }
}