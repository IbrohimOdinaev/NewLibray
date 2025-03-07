namespace DbObjects;

public abstract class DbBasePerson 
{
    public Guid Id {get; set;} 
    public string FirstName {get; set;} = string.Empty;
    public string LastName {get; set;} = string.Empty;
    public DateTime Birthday {get; set;}
}