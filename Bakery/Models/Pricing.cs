namespace Pricing.Models
{
  public class Bread
  {
    public int BreadQty { get; set; }
    public Bread (int breadQty)
    {
      BreadQty = breadQty;
    }
  

  public int ReturnBreadPrice(int bQty)
  {
    int freeBreads = bQty /3;
    // (find rounding function)
    return ((bQty - freeBreads) * 5);
    }

  }


  public class Pastry
  {
    public int PastryQty { get; set; }
    public Pastry (int pastryQty)
    {
      PastryQty = pastryQty;
    }
  
      public int ReturnPastryPrice(int pQty)
    {
      int freePastries= pQty /3;
      return ((pQty - freePastries) * 2);
    }
  }
}

