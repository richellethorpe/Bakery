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
      Gluten newGluten = new Gluten();
      Assert.AreEqual(typeof(Gluten),newGluten.GetType());
    }

  }
}