namespace DbObjects;

public class DbReader : DbBasePerson {
    public static int _countReaders = 1;

    public int ReaderNumber {get; set;}
    public DbLocation? Location {get; set;}
    public DbContacts? Contacts {get; set;}
    public DateTime RegistredAt {get; set;}

    public List<Guid> _bookIssueTransactionsId = new();
}