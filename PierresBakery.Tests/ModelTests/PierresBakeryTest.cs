using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class CalculateCostTest
  {
    [TestMethod]
    public void CalculateBreadPrice_GetsPriceOfOneBread_BreadTotal()
    {
      int BreadPrice = Bread.CalculateBreadPrice(1);
      Assert.AreEqual(BreadPrice, 5);
    }
    [TestMethod]
    public void CalculateBreadPrice_GetsPriceOfTwoBread_BreadTotal()
    {
      int BreadPrice = Bread.CalculateBreadPrice(2);
      Assert.AreEqual(BreadPrice, 10);
    }
  }
}
