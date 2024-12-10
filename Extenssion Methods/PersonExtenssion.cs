using ApplicationData.Models;

namespace Extenssion_Methods;

public static class PersonExtenssion
{
    public static int GetAge(this Person person)
    {
        var today = DateTime.Today;
        var age = today.Year - person.DateOfBirth.Year;
        if (person.DateOfBirth.Date > today.AddYears(-age)) age--;
        return age;
    }

    public static bool IsAdult(this Person person)
    {
        return person.GetAge() >= 18;
    }
}