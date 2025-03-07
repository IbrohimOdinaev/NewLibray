using DbObjects;
using ObjectsDto;
using Enums;

namespace Helpers;

public static class BookServiceHelpers
{
    public static Genres GetGenre() 
    {
        string GenreString = string.Empty;

        Genres Genre;
        
        while (true)
        {
            Console.Write("Genre: ");
            GenreString = Console.ReadLine()!;
            if (Enum.TryParse<Genres>(GenreString, out Genre))
            {
                break;
                
            }
        }
        return Genre;
    }
}