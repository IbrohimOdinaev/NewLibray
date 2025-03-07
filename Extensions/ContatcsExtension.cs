using DbObjects;
using ObjectsDto;

namespace Extensions;

public static class ContactsExtensions
{
    public static DbContacts? ToDbContacts(this ContactsDto contacts) 
        => new()
    {
        Id = contacts.Id,
        PhoneNumber = contacts.PhoneNumber,
        EmailAddress = contacts.EmailAddress,
    };

    public static ContactsDto? ToContactsDto(this DbContacts contacts)
        => new()
    {
        Id = contacts.Id,
        PhoneNumber = contacts.PhoneNumber,
        EmailAddress = contacts.EmailAddress,
    };
}