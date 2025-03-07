using Enums;

namespace ObjectsDto;

public record BookIssueTransactionDto
{
    public Guid Id {get; init;}
    public Guid BookId {get; init;}
    public Guid ReaderId {get; init;}

    public TransactionStatus CurStatus {get; init;}
    public int Penalty {get; init;}

    public DateTime IssueDate {get; init;}
    public DateTime ReturnDate {get; init;}
}