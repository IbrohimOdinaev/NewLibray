using DbObjects;
using ObjectsDto;

namespace Extensions;

public static class BookIssueTransactionExtension 
{
    public static DbBookIssueTransaction? ToDbBookIssueTransaction(this BookIssueTransactionDto bookIssueTransaction)
        => new() 
    {
        Id = bookIssueTransaction.Id,
        BookId = bookIssueTransaction.BookId,
        ReaderId = bookIssueTransaction.ReaderId,

        CurStatus = bookIssueTransaction.CurStatus,
        Penalty = bookIssueTransaction.Penalty,

        IssueDate = bookIssueTransaction.IssueDate,
        ReturnDate = bookIssueTransaction.ReturnDate
    };

    public static BookIssueTransactionDto? ToBookIssueTransactionDto(this DbBookIssueTransaction bookIssueTransaction)
        => new()
    {
        Id = bookIssueTransaction.Id,
        BookId = bookIssueTransaction.BookId,
        ReaderId = bookIssueTransaction.ReaderId,

        CurStatus = bookIssueTransaction.CurStatus,
        Penalty = bookIssueTransaction.Penalty,

        IssueDate = bookIssueTransaction.IssueDate,
        ReturnDate = bookIssueTransaction.ReturnDate
    };
}