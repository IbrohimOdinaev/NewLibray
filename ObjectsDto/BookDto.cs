using Enums;

namespace ObjectsDto;

public record BookDto 
{
    public string Title {get; init;} = string.Empty;
    public Genres Genre {get; init;}
    public DateTime PublicatedIn {get; init;}

    public int NumberOfCopies {get; init;}
    public int NumberOfReaders {get; init;}

    public Guid Id {get; init;}
    public Guid AuthorId {get; init;}
    public Guid PublishingOfficeId {get; init;}
    public Guid TransactionId {get; init;}

    public BookStatus Status {get; init;}
    
}