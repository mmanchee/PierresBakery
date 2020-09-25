using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryCost_CorrectlyCalcPriceFor1Pastry_2()
    {
      Assert.AreEqual(2, Pastry.PastryCost(1));
    }
    [TestMethod]
    public void PastryCost_CorrectlyCalcPriceFor3Pastry_5()
    {
      Assert.AreEqual(5, Pastry.PastryCost(3));
    }
    [TestMethod]
    public void PastryName_CorrectlyIDNameFor1_pastry()
    {
      Assert.AreEqual("pastry", Pastry.PastryName(1));
    }
  }
}