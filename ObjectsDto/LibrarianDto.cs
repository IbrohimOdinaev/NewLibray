namespace ObjectsDto;

public record LibrarianDto : BasePersonDto
{
    public List<Guid> _bookIssueTransactionsId = new();
}