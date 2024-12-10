namespace ApplicationData.Models;

public class Customer
{
    public int CustomerID { get; set; }
    public string CustomerName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
    public Order[] Orders { get; set; }
    public Customer(int customerID, string customerName)
    {
        CustomerID = customerID;
        CustomerName = customerName;
        Orders = new Order[10];
    }
    public Customer()
    {

    }
    public override string ToString()
        => $"Id : {CustomerID}, Name : {CustomerName}, Address : {Address}, City : {City}\n" +
           $"\t Region : {Region}, PostalCode : {PostalCode}, Country : {Country}, Phone : {Phone}, Fax : {Fax}";
}