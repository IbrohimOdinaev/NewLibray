using Enums;

namespace DbObjects;
public class DbBookIssueTransaction 
{
    public Guid Id {get; set;}
    public Guid BookId {get; set;}
    public Guid ReaderId {get; set;}

    public TransactionStatus CurStatus {get; set;}
    public int Penalty {get; set;}

    public DateTime IssueDate {get; set;}
    public DateTime ReturnDate {get; set;}
}