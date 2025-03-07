namespace ObjectsDto;

public record LocationDto 
{
    public string Street {get; init;} = string.Empty;
    public string City {get; init;} = string.Empty;
    public string Country {get; init;} = string.Empty;
    public string Postcode {get; init;} = string.Empty;
}