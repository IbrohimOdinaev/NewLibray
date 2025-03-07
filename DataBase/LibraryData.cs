using DbObjects;

namespace DataBase;

public static class LibraryData
{
    public static readonly Dictionary<Guid, DbBook> _booksBase = new();
    
    public static readonly Dictionary<Guid, DbReader> _readersBase = new();

    public static readonly Dictionary<Guid, DbLibrarian> _librariansBase = new();

    public static readonly Dictionary<Guid, DbAuthor> _authorsBase = new();

    public static readonly Dictionary<Guid, DbPublishingOffice> _publishingOfficesBase = new();

    public static readonly Dictionary<Guid, DbBookIssueTransaction> _bookIssueTransactionsBase = new();

    public static readonly Dictionary<Guid, DbLocation> _locationsBase = new();

    public static readonly Dictionary<Guid, DbContacts> _contatctsBase = new();
}