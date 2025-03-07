using DbObjects;
using ObjectsDto;
using Enums;
using Extensions;
using DataBase;
using Library;
using static Helpers.BaseHelpers;
using static Helpers.BookIssueTransactionHelpers;

namespace Services;

public class BookIssueTransactionService
{
    public void AddBookIssueTransaction()
    {
        Guid bookId = GetId("Book Id: ");
        Guid readerId = GetId("Reader Id: ");
        DateTime issueDate = GetDate("Issue Date: ");
        
        BookIssueTransactionDto bookIssueTransaction = new()
        {
            Id = Guid.NewGuid(),
            BookId = bookId,
            ReaderId = readerId,
            CurStatus = TransactionStatus.Active,
            IssueDate = issueDate
        };

        ReaderService readerService = new();
        BookService bookService = new();

        DbLibrary._bookIssueTransactionsId.Add(bookIssueTransaction.Id);

        DbReader? reader = readerService.Get(readerId);
        reader!._bookIssueTransactionsId.Add(bookIssueTransaction.Id);

        DbBook? book = bookService.Get(bookId);
        book!.TransactionId = bookIssueTransaction.Id;
        book!.Status = BookStatus.Unavailable;

        Console.WriteLine("Book issue transaction added!");
        Console.WriteLine("Book issue transaction Id: " + Create(bookIssueTransaction.ToDbBookIssueTransaction()!));

    }
    public Guid Create(DbBookIssueTransaction bookIssueTransaction)
    {
        LibraryData._bookIssueTransactionsBase[bookIssueTransaction.Id] = bookIssueTransaction;
        return bookIssueTransaction.Id;
    }

    public bool Delete(Guid id)
    {
        if (LibraryData._bookIssueTransactionsBase.TryGetValue(id, out DbBookIssueTransaction? bookIssueTransaction))
        {
            LibraryData._bookIssueTransactionsBase.Remove(id);
            return true;
        }
        return false;
    }

    public bool Update(DbBookIssueTransaction newBookIssueTransaction)
    {
        if (LibraryData._bookIssueTransactionsBase.TryGetValue(newBookIssueTransaction.Id, out DbBookIssueTransaction? bookIssueTransaction))
        {
            LibraryData._bookIssueTransactionsBase[newBookIssueTransaction.Id] = newBookIssueTransaction;
            return true;
        }
        return false;
    }

    public List<DbBookIssueTransaction> Get() => LibraryData._bookIssueTransactionsBase.Values.ToList();

    public DbBookIssueTransaction? Get(Guid id)
    {
        if (LibraryData._bookIssueTransactionsBase.TryGetValue(id, out DbBookIssueTransaction? bookIssueTransaction))
        {
            return bookIssueTransaction;
        }
        return null;
    }

}