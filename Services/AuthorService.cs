using ObjectsDto;
using DbObjects;
using DataBase;
using Extensions;
using Library;
using static Helpers.BaseHelpers;
using static Helpers.AuthorServiceHelpers;


namespace Services;

public class AuthorService : IAuthorService
{ 
    public static AuthorService Instance = new AuthorService();


    public void AddAuthor() 
    {
        Console.WriteLine("Adding new author!");
        
        string newAuthorFirstName = GetValue("First name: ");
        string newAuthorLastName = GetValue("Last name: ");
        DateTime newAuthorBirthday = GetDate("Birthday");
        string newAuthorBiography = GetValue("Biography: ");

        AuthorDto newAuthorDto = new() 
        {
            Id = Guid.NewGuid(),
            FirstName = newAuthorFirstName,
            LastName = newAuthorLastName,
            Birthday = newAuthorBirthday,
            Biography = newAuthorBiography,
        };

        DbLibrary._authorsId.Add(newAuthorDto.Id);

        Console.WriteLine("New author added!");
        Console.WriteLine("New authors Id: " + Create(newAuthorDto.ToDbAuthor()!));
    }

    public bool AddBook(Guid authorId, Guid bookId)
    {
        DbAuthor? author = Get(authorId);
        if(author is null)
            return false;
        author._booksId.Add(bookId);
        return true;
    }

    public Guid Create(DbAuthor author)
    {
        LibraryData._authorsBase[author.Id] = author;
        return author.Id;
    }

    public bool Delete(Guid id)
    {
        if (LibraryData._authorsBase.TryGetValue(id, out DbAuthor? author))
        {
            LibraryData._authorsBase.Remove(id);
            return true;
        }
        return false;
    }

    public bool Update(DbAuthor newAuthor)
    {
        if (LibraryData._authorsBase.TryGetValue(newAuthor.Id, out DbAuthor? author))
        {
            LibraryData._authorsBase[newAuthor.Id] = newAuthor;
            return true;
        }
        return false;
    }

    public List<DbAuthor> Get() => LibraryData._authorsBase.Values.ToList();

    public DbAuthor? Get(Guid id)
    {
        if (LibraryData._authorsBase.TryGetValue(id, out DbAuthor? author))
        {
            return author;
        }
        return null;
    }
}

