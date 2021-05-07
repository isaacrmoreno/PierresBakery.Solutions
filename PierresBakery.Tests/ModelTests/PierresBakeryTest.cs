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
  }
}
