using System;
using Pricing.Models;

namespace BakeShop 
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Gluten for your Glutes Bakeshop. How many loaves of bread would you like to purchase?");
      string bStringQty = Console.ReadLine();
      int bQty = int.Parse(bStringQty);
      Console.WriteLine("You selected " + bQty + " loaves of bread. How many pastries would you like to purchase?");
      string pStringQty = Console.ReadLine();
      int pQty = int.Parse(pStringQty);
      Bread newBread = new Bread(bQty);
      Pastry newPastry = new Pastry(pQty);
      int total = newBread.ReturnBreadPrice(bQty)  + newPastry.ReturnPastryPrice(pQty);
      string stringTotal = total.ToString();
      Console.WriteLine("Thank you for your order. You have have selected " + bQty + " loaves of bread and " + pQty + " pastries. Your total comes to $" + stringTotal + ".");

    }
  }
}