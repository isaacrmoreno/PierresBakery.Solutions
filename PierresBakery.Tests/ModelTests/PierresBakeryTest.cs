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
    [TestMethod]
    public void CalculateBreadPrice_GetsPriceOfThreeBread_BreadTotal()
    {
      int BreadPrice = Bread.CalculateBreadPrice(3);
      Assert.AreEqual(BreadPrice, 10);
    }
    [TestMethod]
    public void CalculateBreadPrice_GetsPriceOfNineBread_BreadTotal()
    {
      int BreadPrice = Bread.CalculateBreadPrice(9);
      Assert.AreEqual(BreadPrice, 30);
    }
    [TestMethod]
    public void CalculateBreadPrice_GetsPriceOf267Bread_BreadTotal()
    {
      int BreadPrice = Bread.CalculateBreadPrice(267);
      Assert.AreEqual(BreadPrice, 100000);
    }
  }
}
