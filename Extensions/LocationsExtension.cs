using DbObjects;
using ObjectsDto;

namespace Extensions;

public static class LocationExtensions 
{
    public static DbLocation? ToDbLocation(this LocationDto location)
        => new()
    {
        Street = location.Street,
        City = location.City,
        Country = location.Country,
        Postcode = location.Postcode,
    };

    public static LocationDto? ToLocationDto(this DbLocation location)
        => new()
    {
        Street = location.Street,
        City = location.City,
        Country = location.Country,
        Postcode = location.Postcode
    };
}