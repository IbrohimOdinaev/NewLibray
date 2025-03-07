using DbObjects;
using ObjectsDto;
using DataBase;
using Extensions;
using Library;
using static Helpers.BaseHelpers;
using static Helpers.LibrarianServiceHelpers;


namespace Services;

public class LibrarianService : ILibrarianService
{
    public static LibrarianService Instance = new LibrarianService();

    public void AddLibrarian()
    {
        Console.WriteLine("Adding new librarian!");

        string newLibrarianFirstName = GetValue("First name: ");
        string newLibrarianLastName = GetValue("Last name: ");
        DateTime newLibrarianBirthday = GetDate("Birthday");
        
        LibrarianDto newLibrarian = new() 
        {
            Id = Guid.NewGuid(),
            FirstName = newLibrarianFirstName,
            LastName = newLibrarianLastName,
            Birthday= newLibrarianBirthday
        };

        DbLibrary._librariansId.Add(newLibrarian.Id);

        Console.WriteLine("New librarian added!");
        Console.WriteLine("New librarians Id: " + Create(newLibrarian.ToDbLibrarian()));
    }
    public Guid Create(DbLibrarian librarian)
    {
        LibraryData._librariansBase[librarian.Id] = librarian;
        return librarian.Id;
    }

    public bool Delete(Guid Id)
    {
        if (LibraryData._librariansBase.TryGetValue(Id, out DbLibrarian? librarian))
        {
            LibraryData._librariansBase.Remove(Id);
            return true;
        }
        return false;
    }

    public bool Update(DbLibrarian newLibrarian)
    {
        if (LibraryData._librariansBase.TryGetValue(newLibrarian.Id, out DbLibrarian? librarian))
        {
            LibraryData._librariansBase[newLibrarian.Id] = newLibrarian;
            return true;
        }
        return false;
    }

    public List<DbLibrarian> Get() => LibraryData._librariansBase.Values.ToList();

    public DbLibrarian? Get(Guid Id)
    {
        if (LibraryData._librariansBase.TryGetValue(Id, out DbLibrarian? librarian))
        {
            return librarian;
        }
        return null;
    }
}