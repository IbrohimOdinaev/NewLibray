using DbObjects;
using ObjectsDto;
using Extensions;
using DataBase;
using Enums;
using Library;
using static Helpers.BaseHelpers;
using static Helpers.BookServiceHelpers;

namespace Services;

public class BookService : IBookService
{
    public void AddBook()
    {
        Console.WriteLine("Adding new book!");

        string newBookTitle = GetValue("Title: ");
        Genres newBookGenre = GetGenre();
        DateTime newBookPublicatedIn = GetDate("Publicated in: ");
        Guid newBookAuthorId = GetId("Authors Id: ");
        Guid newBookPublishingOfficeId = GetId("Publishing Office Id: ");
        int newBookNumberOfCopies = GetQuantity("Number of copies: ");

        BookDto newBook = new()
        {
            Title = newBookTitle,
            Genre = newBookGenre,
            PublicatedIn = newBookPublicatedIn,
            NumberOfCopies = newBookNumberOfCopies,
            Id = Guid.NewGuid(),
            AuthorId = newBookAuthorId,
            PublishingOfficeId = newBookPublishingOfficeId,
            Status = BookStatus.Available
        };

        DbBook? newDbBook = newBook.ToDbBook();
        newDbBook!.NumberOfReaders++;

        AuthorService authorService = new();
        PublishingOfficeService publishingOfficeService = new();

        if(!authorService.AddBook(newBookAuthorId, newDbBook.Id))
            Console.WriteLine("Undefined auhtor!");

        if (!publishingOfficeService.AddBook(newBookPublishingOfficeId, newDbBook.Id))
            Console.WriteLine("Undefined Publishing office!");

        DbLibrary._booksId.Add(newBook.Id);

        Console.WriteLine("New book added!");
        Console.WriteLine("New books Id: " + Create(newDbBook));
    }

    public Guid Create(DbBook book)
    {
        LibraryData._booksBase[book.Id] = book;
        return book.Id;
    }

    public bool Delete(Guid id)
    {
        if (LibraryData._booksBase.TryGetValue(id, out DbBook? book))
        {
            LibraryData._booksBase.Remove(id);
            return true;
        }
        return false;
    }

    public bool Update(DbBook newBook)
    {
        if (LibraryData._booksBase.TryGetValue(newBook.Id, out DbBook? book))
        {
            LibraryData._booksBase[newBook.Id] = newBook;
            return true;
        }
        return false;
    }

    public List<DbBook> Get() => LibraryData._booksBase.Values.ToList();

    public DbBook? Get(Guid id)
    {
        if (LibraryData._booksBase.TryGetValue(id, out DbBook? book))
        {
            return book;
        }
        return null;
    }
}