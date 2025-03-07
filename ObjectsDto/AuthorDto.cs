namespace ObjectsDto;

public record AuthorDto : BasePersonDto 
{
    public string Biography {get; init;} = string.Empty;
    
    
    public List<Guid> _booksId = new();
}