using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pricing.Models;
using System;

namespace Pricing.Tests
{
  [TestClass]
  public class PricingTests
  {
    [TestMethod]
    public void GlutenConstructor_CreateInstance_Gluten()
    {
      Gluten newGluten = new Gluten(6, 7);
      Assert.AreEqual(typeof(Gluten),newGluten.GetType());
    }

    [TestMethod]
    public void GetBreadQty_ReturnBreadQty_Int()
    {
      int breadQty = 4;
      int pastryQty = 5;
      Gluten newGluten = new Gluten(breadQty, pastryQty);
      string result = newGluten.BreadQty;
      Assert.AreEqual(breadQty, result);
    }
  }
}