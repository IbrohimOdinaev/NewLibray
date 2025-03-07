using DbObjects;
using ObjectsDto;
using System.ComponentModel;

namespace Helpers;

public static class BaseHelpers
{
    public static string GetValue(string text)
    {
        Console.Write(text);
        return Console.ReadLine()!;
    }
    
    public static DateTime GetDate(string text)
    {
        string Date = string.Empty;
        do
        {
            Console.Write($"{text} (YYYY-MM-DD): ");
            Date = Console.ReadLine()!;
        } 
        while(!IsFormatCorrect<DateTime>(Date!));
        return  DateTime.Parse(Date);
    }

    public static LocationDto GetLocation() 
    {
        Console.Write("Country: ");
        string newCountry = Console.ReadLine()!;
        
        Console.Write("City: ");
        string newCity = Console.ReadLine()!;

        Console.Write("Street: ");
        string newStreet = Console.ReadLine()!;

        Console.Write("Postcode: ");
        string newPostcode = Console.ReadLine()!;

        LocationDto newLocation = new()
        {
            Country = newCountry,
            City = newCity,
            Street = newStreet,
            Postcode = newPostcode
        };
        return newLocation;
    }

    public static ContactsDto GetContacts()
    {
        Console.Write("Phone Number: ");
        string phoneNumber = Console.ReadLine()!;

        Console.Write("Email Address: ");
        string emailAddress = Console.ReadLine()!;

        ContactsDto contacts = new() 
        {
            PhoneNumber = phoneNumber,
            EmailAddress = emailAddress,
        };

        return contacts;
    }

    public static bool IsFormatCorrect<T>(string input)
    {
        TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
        if(converter.IsValid(input))
        {
            return true;
        } 
        Console.WriteLine("Wrong Format");
        return false;
    }

    public static Guid GetId(string text)
    {
        string id;
        do
        {
            Console.Write(text);
            id = Console.ReadLine()!;
        } while(!IsFormatCorrect<Guid>(id!));
        
        return (Guid.Parse(id));
    }

    public static int GetQuantity(string text)
    {
        string quantity;
        do
        {
            Console.Write(text);
            quantity = Console.ReadLine()!;
        } while(!IsFormatCorrect<int>(quantity!));

        return (int.Parse(quantity!));
    }
}