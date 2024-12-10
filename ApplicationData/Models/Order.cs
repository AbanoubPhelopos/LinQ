namespace ApplicationData.Models;

public class Order
{
    public int OrderID { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Total { get; set; }

    public Order(int orderID, DateTime orderDate, decimal total)
    {
        OrderID = orderID;
        OrderDate = orderDate;
        Total = total;
    }
    public Order()
    {

    }

    public override string ToString()
        => $"Order Id: {OrderID}, Date: {OrderDate.ToShortDateString()}, Total: {Total}";
}