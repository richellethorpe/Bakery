using System;

namespace Pricing.Models
{
  public class Gluten
  {
    public int BreadQty { get; set; }
    public int PastryQty { get; set; }
    public Gluten (int breadQty, int pastryQty)
    {
      BreadQty = breadQty;
      PastryQty = pastryQty;
    }
  }

  public int ReturnBreadPrice(int bQty)
  {
    int freeBreads = bQty /3;
    // (find rounding function)
    return ((bQty - freeBreads) * 5);
    }
  

  public int ReturnPastryPrice(int pQty)
    {
      int freePastries= pQty /3;
      return ((pQty - freePastries) * 2);
    }
}

