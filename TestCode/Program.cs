using ApplicationData.Data;
using ApplicationData.Models;

namespace TestCode;

class Program
{
    static void Main(string[] args)
    {
        ApplicationDbContext _db = new();
        var customers = _db.Customers.ToList();
        foreach (var item in customers)
        {
            Console.WriteLine(item);
        }
    }
}