using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry("test", 0, 0);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetObject_ReturnsObject_Object()
    {
      //Arrange
      string name = "loaf";
      int number = 0;
      int cost = 0;

      //Act
      Pastry result = new Pastry(name, number, cost);

      //Assert
      Assert.AreEqual(name, result.Name);
      Assert.AreEqual(number, result.Number);
      Assert.AreEqual(cost, result.Cost);
    }

    [TestMethod]
    public void SetObject_SetObject_Pastry()
    {
      //Arrange
      string name = "loaf";
      int number = 0;
      int cost = 0;
      Pastry newPastry = new Pastry(name, number, cost);

      //Act
      string updatedName = "loaves";
      newPastry.Name = updatedName;
      string result1 = newPastry.Name;
      int updatedNumber = 2;
      newPastry.Number = updatedNumber;
      int result2 = newPastry.Number;
      int updatedCost = 2;
      newPastry.Cost = updatedCost;
      int result3 = newPastry.Cost;

      //Assert
      Assert.AreEqual(updatedName, result1);
      Assert.AreEqual(updatedNumber, result2);
      Assert.AreEqual(updatedCost, result3);
    }
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
    [TestMethod]
    public void PastryName_CorrectlyIDNameFor3_pastries()
    {
      Assert.AreEqual("pastries", Pastry.PastryName(3));
    }
  }
}