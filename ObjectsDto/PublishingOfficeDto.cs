namespace ObjectsDto;

public record PublishingOfficeDto {
    public Guid Id {get; init;}

    public string Title {get; init;} = string.Empty;
    public LocationDto? Location {get; init;}
    public ContactsDto? Contacts {get; init;}

    public List<Guid> _booksId = new();
}