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
    [TestMethod]
    public void BreadCost_CorrectlyCalcPriceFor3Loaf_10()
    {
      Assert.AreEqual(10, Bread.BreadCost(3));
    }
    [TestMethod]
    public void BreadName_CorrectlyIDNameFor1_loaf()
    {
      Assert.AreEqual("loaf", Bread.BreadCost(1));
    }
  }
}