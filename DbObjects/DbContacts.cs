namespace DbObjects;

public class DbContacts 
{
    public Guid Id {get; set;}
    public string PhoneNumber {get; set;} = string.Empty;
    public string EmailAddress {get; set;} = string.Empty;
}