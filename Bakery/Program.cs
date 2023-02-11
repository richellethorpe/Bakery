using System;
using Pricing.Models;

namespace BakeShop 
{
  pulic class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Gluten for your Glutes Bakeshop. How many loaves of bread would you like to purchase?");
      string bStringQty = Console.ReadLine();
      int bQty = int.Parse(bStringQty);
      Console.WriteLine("You selected" + bQty + "loaves of bread. How many pastries would you like to purchase?");
      string pStringQty = Console.ReadLine();
      int pQty = int.Parse(pStringQty);
      //follow up on how to call functions below
      int total = ReturnBreadPrice(int bQty) + ReturnPastryPrice(int pQty)
      string stringTotal = total.ToString();
      Console.WriteLine("Thank you for your order. You have have selected" + bQty + "loaves of bread and " + pQty + "pastries. Your total comes to $" + stringTotal);



    }
  }
}