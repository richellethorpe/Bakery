using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pricing.Models;
using System;

namespace Pricing.Tests
{
  [TestClass]
  public class PricingTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstance_Bread()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread),newBread.GetType());
    }

     [TestMethod]
    public void PastryConstructor_CreateInstance_Pastry()
    {
      Pastry newPastry = new Pastry(5);
      Assert.AreEqual(typeof(Pastry),newPastry.GetType());
    }
  

    [TestMethod]
    public void BreadContstructor_ReturnBreadQty_Int()
    {
      int breadQty = 4;
      Bread newBread = new Bread(breadQty);
      int result = newBread.BreadQty;
      Assert.AreEqual(breadQty, result);
    }

    [TestMethod]
    public void PastryContstructor_ReturnPastryQty_Int()
    {
      int pastryQty = 4;
      Pastry newPastry = new Pastry(pastryQty);
      int result = newPastry.PastryQty;
      Assert.AreEqual(pastryQty, result);
    }

    [TestMethod]
    public void ReturnPastryPrice_ReturnPastryPrice_Int()  
    {
      int pastryQty = 8;
      Pastry newPastry = new Pastry(pastryQty);
      int pastryPrice = newPastry.ReturnPastryPrice(pastryQty);
      Assert.AreEqual(pastryPrice, 12);

    }

    [TestMethod]
    public void ReturnBreadPrice_ReturnBreadPrice_Int()  
    {
      int breadQty = 7;
      Bread newBread = new Bread(breadQty);
      int breadPrice = newBread.ReturnBreadPrice(breadQty);
      Assert.AreEqual(breadPrice, 25);

    }
  }
}



