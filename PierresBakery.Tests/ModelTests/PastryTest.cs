using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class CalculatePastryCostTest
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Pastry newPastry = new(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    // [TestMethod]
    // public void CalculatePastryPrice_GetsPriceOfOnePastry_PastryTotal()
    // {
    //   int PastryPrice = Pastry.CalculatePastryPrice(1);
    //   Assert.AreEqual(PastryPrice, 2);
    // }
    // [TestMethod]
    // public void CalculatePastryPrice_GetsPriceOfTwoPastry_PastryTotal()
    // {
    //   int PastryPrice = Pastry.CalculatePastryPrice(2);
    //   Assert.AreEqual(PastryPrice, 4);
    // }
    // [TestMethod]
    // public void CalculatePastryPrice_GetsPriceOfThreePastry_PastryTotal()
    // {
    //   int PastryPrice = Pastry.CalculatePastryPrice(3);
    //   Assert.AreEqual(PastryPrice, 5);
    // }
    // [TestMethod]
    // public void CalculatePastryPrice_GetsPriceOfNinePastry_PastryTotal()
    // {
    //   int PastryPrice = Pastry.CalculatePastryPrice(9);
    //   Assert.AreEqual(PastryPrice, 15);
    // }
    // [TestMethod]
    // public void CalculatePastryPrice_GetsPriceOf362Pastry_PastryTotal()
    // {
    //   int PastryPrice = Pastry.CalculatePastryPrice(362);
    //   Assert.AreEqual(PastryPrice, 724);
    // }
  }
}
