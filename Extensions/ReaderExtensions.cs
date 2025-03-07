using DbObjects;
using ObjectsDto;

namespace Extensions;

public static class ReaderExtensions
{
    public static DbReader? ToDbReader(this ReaderDto reader)
        => new()
    {
        Id = reader.Id,
        FirstName = reader.FirstName,
        LastName = reader.LastName,

        ReaderNumber = reader.ReaderNumber,
        Location = reader.Location!.ToDbLocation(),
        Contacts = reader.Contacts!.ToDbContacts()
    };


    public static ReaderDto? ToReaderDto (this DbReader reader)
        => new() 
    {
        Id = reader.Id,
        FirstName = reader.FirstName,
        LastName = reader.LastName,

        ReaderNumber = reader.ReaderNumber,
        Location = reader.Location!.ToLocationDto(),
        Contacts = reader.Contacts!.ToContactsDto(),
        
        _bookIssueTransactionsId = reader._bookIssueTransactionsId
    };
}