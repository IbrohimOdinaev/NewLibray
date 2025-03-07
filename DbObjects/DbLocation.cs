namespace DbObjects;

public class DbLocation
{
    public Guid Id {get; set;}
    public string Country {get; set;} = string.Empty;
    public string City {get; set;} = string.Empty;
    public string Street {get; set;} = string.Empty;
    public string Postcode {get; set;} = string.Empty;
}