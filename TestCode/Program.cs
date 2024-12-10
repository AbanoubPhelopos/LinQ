using ApplicationData.Data;
using ApplicationData.Models;
using Extenssion_Methods;
using LinQ;

namespace TestCode;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("Problem: Without Extension Methods");
        WithoutExtensionMethods();
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Solution: With Extension Methods");
        WithExtensionMethods();*/
        
        Projection.Query();
    }
    static void WithoutExtensionMethods()
    {
        var person = new Person { Name = "Alice", DateOfBirth = new DateTime(1990, 5, 15) };
        // Calculate age requires separate utility class or inline calculation
        int age = CalculateAge(person.DateOfBirth);
        Console.WriteLine($"Age calculated without extension: {age}");
    }
    static int CalculateAge(DateTime dateOfBirth)
    {
        var today = DateTime.Today;
        var age = today.Year - dateOfBirth.Year;
        if (dateOfBirth.Date > today.AddYears(-age)) age--;
        return age;
    }
    static void WithExtensionMethods()
    {
        var person = new Person { Name = "Alice", DateOfBirth = new DateTime(1990, 5, 15) };
        Console.WriteLine($"Age calculated with extension: {person.GetAge()}");
        Console.WriteLine($"Is adult? {person.IsAdult()}");

        string input = "             HELLO world         ";
        string processed = input
            .Trim();
            //.ToLower();
        Console.WriteLine($"Chained extensions result: {processed}");
    }

}