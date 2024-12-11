using ApplicationData.Data;
using ApplicationData.Models;

namespace LinQ;

public static class Queries
{
    static ApplicationDbContext _db = new();
    /*
        1. Find all products that are out of stock.
        2. Find all products that are in stock and cost more than 3.00 per unit and its price more than 15 $.
        3. Sort a list of products by name
        4. Sort a list of products by category then for the same category sort by price
        5. Return a sequence of just the names of a list of products.
        6. Return the first product whose Price > 1000, unless there is no match, in which case null is 
        7. Return a list of categories and how many products each has
        8. Get the total units in stock for each product category.
        9. Find the unique Category names from Product List
        10. Get the first 3 Products with Price more than 80
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
        //Problem 6
        var query = _db.Products.FirstOrDefault(p => p.UnitPrice > 1000);
        Console.WriteLine(query);
        */

        /*
        //Problem 7
        var query = _db.Products.GroupBy(p => p.Category)
            .Select(group => new
            {
                Category = group.Key,
                ProductCount = group.Count()
            });
        */
        
        /*
         //Problem 8
        var query = _db.Products
            .GroupBy(p => p.Category)
            .Select(group => new
            {
                Category = group.Key,
                TotalUnitsInStock = group.Sum(p => p.UnitsInStock)
            });
            */
        
        /*
        //Problem 9 
        // what is the differance
        var query = _db.Products.Distinct().Select(p => p.Category);
        var query1 = _db.Products.Select(p=>p.Category).Distinct();
        */
        
        /*
        //Problem 10
        var query = _db.Products.Where(p=>p.UnitPrice>80).Take(3);
        */
        
        /*
        foreach (var item in query)
        {
            Console.WriteLine(item);
        }
        */
        
    }
}