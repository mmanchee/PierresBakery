using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadCost_CorrectlyCalcPriceFor1Loaf_5()
    {
      Assert.AreEqual(5, Bread.BreadCost(1));
    }
  }
}