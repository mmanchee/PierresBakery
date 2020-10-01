using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread("test", 0, 0);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetObject_ReturnsObject_Object()
    {
      //Arrange
      string name = "loaf";
      int number = 0;
      int cost = 0;

      //Act
      Bread result = new Bread(name, number, cost);

      //Assert
      Assert.AreEqual(name, result.Name);
      Assert.AreEqual(number, result.Number);
      Assert.AreEqual(cost, result.Cost);
    }

    [TestMethod]
    public void SetObject_SetObject_Bread()
    {
      //Arrange
      string name = "loaf";
      int number = 0;
      int cost = 0;
      Bread newBread = new Bread(name, number, cost);

      //Act
      string updatedName = "loaves";
      newBread.Name = updatedName;
      string result1 = newBread.Name;
      int updatedNumber = 2;
      newBread.Number = updatedNumber;
      int result2 = newBread.Number;
      int updatedCost = 2;
      newBread.Cost = updatedCost;
      int result3 = newBread.Cost;

      //Assert
      Assert.AreEqual(updatedName, result1);
      Assert.AreEqual(updatedNumber, result2);
      Assert.AreEqual(updatedCost, result3);
    }
    
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
      Assert.AreEqual("loaf", Bread.BreadName(1));
    }
    [TestMethod]
    public void BreadName_CorrectlyIDNameFor3_loaves()
    {
      Assert.AreEqual("loaves", Bread.BreadName(3));
    }
  }
}