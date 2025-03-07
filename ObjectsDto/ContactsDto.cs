namespace ObjectsDto;

public class ContactsDto
{
    public Guid Id {get; init;}
    public string PhoneNumber {get; init;} = string.Empty;
    public string EmailAddress {get; init;} = string.Empty;
}