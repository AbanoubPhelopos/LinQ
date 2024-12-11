using ApplicationData.Data;
using ApplicationData.Models;
using Extenssion_Methods;
using LinQ;

namespace TestCode;

class Program
{
    static void Main(string[] args)
    {
        Extenssions.WithoutExtensionMethods();
        Console.WriteLine("--------------------------------------------------------");
        Extenssions.WithExtensionMethods();
        
        Queries.Query();
        HandsOn.Answer();
    }
}