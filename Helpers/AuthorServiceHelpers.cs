using ObjectsDto;
using DbObjects;

namespace Helpers;

public static class AuthorServiceHelpers
{
    public static string GetBiography()
    {
        Console.Write("Short biography: ");
        return Console.ReadLine()!;
    }
}