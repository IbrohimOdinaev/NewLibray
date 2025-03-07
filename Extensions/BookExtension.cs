using DbObjects;
using ObjectsDto;

namespace Extensions;

public static class BookExtension
{
    public static DbBook? ToDbBook(this BookDto book)
        => new()
    {
        Title = book.Title,
        Genre = book.Genre,
        PublicatedIn = book.PublicatedIn,

        Id = book.Id,
        AuthorId = book.AuthorId,
        PublishingOfficeId = book.PublishingOfficeId
    };

    public static BookDto? ToBookDto(this DbBook book)
        => new()
    {
        Title = book.Title,
        Genre = book.Genre,
        PublicatedIn = book.PublicatedIn,

        Id = book.Id,
        AuthorId = book.AuthorId,
        PublishingOfficeId = book.PublishingOfficeId
    };
    
}