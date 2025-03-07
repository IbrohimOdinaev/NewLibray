namespace ObjectsDto;

public record ReaderDto : BasePersonDto
{
    public static int _countReaders = 1;

    public int ReaderNumber {get; init;}
    public LocationDto? Location {get; init;}
    public ContactsDto? Contacts {get; init;}
    public DateTime RegistredAt {get; init;} = DateTime.Today;
    

    public List<Guid> _bookIssueTransactionsId = new();
}