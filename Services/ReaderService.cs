using DbObjects;
using ObjectsDto;
using DataBase;
using AuxilaryObjects;
using Extensions;
using Library;
using static Helpers.BaseHelpers;
using static Helpers.ReaderServiceHelpers;

namespace Services;

public class ReaderService : IReaderService
{
    public void AddReader()
    {   
        Console.WriteLine("Adding new reader!");

        string newReaderFirstName = GetValue("First name: ");
        string newReaderLastName = GetValue("Last name: ");
        DateTime newReaderBirthday = GetDate("Birthday");
        LocationDto newReaderLocation = GetLocation();
        ContactsDto newReaderContacts = GetContacts();

        ReaderDto newReaderDto = new()
        {
            Id = Guid.NewGuid(),
            FirstName = newReaderFirstName,
            LastName = newReaderLastName,
            Birthday = newReaderBirthday,
            Location = newReaderLocation,
            Contacts = newReaderContacts
        };
        DbLibrary._readersId.Add(newReaderDto.Id);


        DbReader._countReaders++;
        ReaderDto._countReaders++;

        Console.WriteLine("New Reader Added!");
        Console.WriteLine("New Readers Id: " + Create(newReaderDto.ToDbReader()!));
    }

    public Guid Create(DbReader reader)
    {
        LibraryData._readersBase[reader.Id] = reader;
        return reader.Id;
    }

    public bool Delete(Guid id)
    {
        if (LibraryData._readersBase.TryGetValue(id, out DbReader? reader))
        {
            LibraryData._readersBase.Remove(id);
            return true;
        }
        return false;
    }

    public bool Update(DbReader newReader)
    {
        if (LibraryData._readersBase.TryGetValue(newReader.Id, out DbReader? reader)) 
        {
            LibraryData._readersBase[newReader.Id] = newReader;

            return true;
        } 
        return false;
    }

    public List<DbReader> Get()
        => LibraryData._readersBase.Values.ToList();
    
    public DbReader? Get(Guid id)
    {
        if (LibraryData._readersBase.TryGetValue(id, out DbReader? reader)) 
        {
            return reader;
        }
        return null;
    }

}

