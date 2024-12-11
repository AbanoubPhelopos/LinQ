using ApplicationData.Models;

namespace Extenssion_Methods;

public static class Extenssions
{
    public static void WithoutExtensionMethods()
    {
        var person = new Person { Name = "Alice", DateOfBirth = new DateTime(1990, 5, 15) };
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

    public static void WithExtensionMethods()
    {
        var person = new Person { Name = "Alice", DateOfBirth = new DateTime(1990, 5, 15) };
        Console.WriteLine($"Age calculated with extension: {person.GetAge()}");
        Console.WriteLine($"Is adult? {person.IsAdult()}");
    }

    public static void StringExtenssion()
    {
        string input = "             HELLO world         ";
        string processed = input
            .Trim();
        //.ToLower();
        Console.WriteLine($"Chained extensions result: {processed}");
    }
}