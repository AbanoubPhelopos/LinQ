using ApplicationData.Data;
using ApplicationData.Models;

namespace LinQ;

public static class Projection
{
    static ApplicationDbContext _db = new();
    /*
        1. Find all products that are out of stock.
        2. Find all products that are in stock and cost more than 3.00 per unit and its price more than 15 $.
        3. Sort a list of products by name
        4. Sort a list of products by category then for the same category sort by price
        5. Return a sequence of just the names of a list of products.
     */
    public static void Query()
    {
        /*
        //problem 1
        //query expression
        var query = from product in _db.Products where product.UnitsInStock==0 select product;
        
        //Method syntax
        query =_db.Products.Where(p=>p.UnitsInStock==0);
        */
        
        /*
        //Problem 2 
        var query = from product in _db.Products 
                        where product.UnitsInStock>3 && product.UnitPrice > 15 select product;
        query=_db.Products.Where(p => p.UnitsInStock > 3 && p.UnitPrice > 15);
        */
        
        /*
        //Problem 3
        var query = from product in _db.Products
            orderby product.ProductName
            select product;
        query = _db.Products.OrderBy(p => p.ProductName);
        */
        
        /*
        //Problem 4 
        var query = _db.Products.OrderBy(p => p.Category)
                                                            .ThenBy(p => p.UnitPrice);
        */
        
        /*
        //Problem 5 
        var query = from product in _db.Products select product.ProductName;
        query = _db.Products.Select(p=>p.ProductName);
        */
        
        /*
        foreach (var item in query)
        {
            Console.WriteLine(item);
        }
        */
    }
}