namespace DbObjects;

public class DbAuthor : DbBasePerson 
{
    public string Biography {get; set;} = string.Empty;

    public List<Guid> _booksId = new();
}