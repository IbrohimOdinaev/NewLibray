namespace ObjectsDto;

public record BasePersonDto 
{
    public Guid Id {get; init;}
    
    public string FirstName {get; init;} = string.Empty;
    public string LastName {get; init;} = string.Empty;
    public DateTime Birthday {get; init;}
}