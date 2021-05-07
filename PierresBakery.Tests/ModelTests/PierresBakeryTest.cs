using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery
{
  [TestClass]
  public class CalculateCostTest
  {
    [TestMethod]
    public void CalculateBreadPrice_ApplyDiscount_BreadTotal()
    {
      int BreadQty = Bread.CalculateBreadPrice(BreadPrice);
      Assert.AreEqual(BreadPrice);
    }
  }
}