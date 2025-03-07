namespace DbObjects;

public class DbLibrarian : DbBasePerson
{
    public List<Guid> _bookIssueTransactionsId = new();
}