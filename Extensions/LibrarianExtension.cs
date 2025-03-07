using DbObjects;
using ObjectsDto;

namespace Extensions;

public static class LibrarianExtension 
{
    public static DbLibrarian ToDbLibrarian(this LibrarianDto librarian)
        => new()
    {
        Id = librarian.Id,
        FirstName = librarian.FirstName,
        LastName = librarian.LastName,
    };

    public static LibrarianDto ToLibrarianDto(this DbLibrarian librarian)
        => new()
    {
        Id = librarian.Id,
        FirstName = librarian.FirstName,
        LastName = librarian.LastName,

        _bookIssueTransactionsId = librarian._bookIssueTransactionsId
    };
}