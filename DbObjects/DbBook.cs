using Enums;

namespace DbObjects;

public class DbBook 
{
    public string Title {get; set;} = string.Empty;
    public Genres Genre {get; set;}
    public DateTime PublicatedIn {get; set;}

    public  int NumberOfCopies {get; set;}
    public int NumberOfReaders {get; set;}

    public Guid Id {get; set;}
    public Guid AuthorId {get; set;}
    public Guid PublishingOfficeId {get; set;}
    public Guid TransactionId {get; set;}

    public BookStatus Status {get; set;}
}