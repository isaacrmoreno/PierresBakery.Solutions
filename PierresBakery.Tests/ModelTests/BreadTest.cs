using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class CalculateCostTest
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    // [TestMethod]
    // public void CalculateBreadPrice_GetsPriceOfOneBread_BreadTotal()
    // {
    //   int BreadPrice = Bread.CalculateBreadPrice(1);
    //   Assert.AreEqual(BreadPrice, 5);
    // }
    // [TestMethod]
    // public void CalculateBreadPrice_GetsPriceOfTwoBread_BreadTotal()
    // {
    //   int BreadPrice = Bread.CalculateBreadPrice(2);
    //   Assert.AreEqual(BreadPrice, 10);
    // }
    // [TestMethod]
    // public void CalculateBreadPrice_GetsPriceOfThreeBread_BreadTotal()
    // {
    //   int BreadPrice = Bread.CalculateBreadPrice(3);
    //   Assert.AreEqual(BreadPrice, 10);
    // }
    // [TestMethod]
    // public void CalculateBreadPrice_GetsPriceOfNineBread_BreadTotal()
    // {
    //   int BreadPrice = Bread.CalculateBreadPrice(9);
    //   Assert.AreEqual(BreadPrice, 30);
    // }
    // [TestMethod]
    // public void CalculateBreadPrice_GetsPriceOf268Bread_BreadTotal()
    // {
    //   int BreadPrice = Bread.CalculateBreadPrice(268);
    //   Assert.AreEqual(BreadPrice, 1340);
    // }

  }
}
