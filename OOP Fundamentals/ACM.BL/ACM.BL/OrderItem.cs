using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
  public class OrderItem
  {

    public OrderItem()
    {

    }
    public OrderItem(int orderItemId)
    {
      OrderItemId = orderItemId;
    }

    public int OrderItemId { get; set; }
    public int ProductId { get; set; }
    public decimal? PurchasePrice { get; set; }
    public int Quantity { get; set; }

    ///<summary>
    /// Retrieve one order item.
    ///</summary>
    public OrderItem Retrieve(int orderItemId)
    {
      // Code that retrieves the defined customer

      return new OrderItem();
    }

    /// <summary>
    /// Saves the current customer.
    /// </summary>
    /// <returns></returns>
    public bool Save()
    {
      // Code that saves the defined customer

      return true;
    }

    /// <summary>
    /// Validates the customer data. 
    /// </summary>
    ///
    public bool Validate()
    {
      var isValid = true;

      if (Quantity <= 0) isValid = false;
      if (ProductId <= 0) isValid = false;
      if (PurchasePrice == null) isValid = false;

      return isValid;

    }

  }
}
