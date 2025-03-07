using AuxilaryObjects;
using DbObjects;

namespace Library;

public static class DbLibrary 
{
    public static string Title {get; set;} = AuxilaryConstants._library;

    public static DbLocation? Location {get; set;}

    public static List<Guid> _authorsId {get;} = new();
    public static List<Guid> _booksId {get;} = new();
    public static List<Guid> _readersId {get;} = new();
    public static List<Guid> _librariansId {get;} = new();
    public static List<Guid> _publishingOfficesId {get;} = new();
    public static List<Guid> _bookIssueTransactionsId {get;} = new();
    
}