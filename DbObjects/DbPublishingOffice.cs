namespace DbObjects;

public class DbPublishingOffice 
{
    public Guid Id {get; set;}

    public string Title {get; set;} = string.Empty;
    public DbLocation? Location {get; set;}
    public DbContacts? Contacts {get; set;}

    public List<Guid> _booksId = new();
}