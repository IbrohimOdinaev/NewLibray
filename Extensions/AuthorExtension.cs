using DbObjects;
using ObjectsDto;

namespace Extensions;

public static class AuthorExtension {
    public static DbAuthor? ToDbAuthor (this AuthorDto author)
        => new() 
    {
        Id = author.Id,
        FirstName = author.FirstName,
        LastName = author.LastName,
        Biography = author.Biography
    };
    
    public static AuthorDto? ToAuthorDto (this DbAuthor author) 
        => new()
    {
        Id = author.Id,
        FirstName = author.FirstName,
        LastName = author.LastName,
        Biography = author.Biography,
        _booksId = author._booksId
    };
}