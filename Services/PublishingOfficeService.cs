using DbObjects;
using ObjectsDto;
using Extensions;
using Library;
using DataBase;
using Enums;
using static Helpers.BaseHelpers;
using static Helpers.PublishingOfficeHelpers;

namespace Services;

public class PublishingOfficeService : IPublishingOfficeService
{
    public void AddPublishingOffice()
    {
       string newPublishingOfficeTitle = GetValue("Title: ");
       LocationDto newPublishingOfficeLocation = GetLocation();
       ContactsDto newPublishingOfficeContacts = GetContacts();

       PublishingOfficeDto newPublishingOffice = new()
       {
            Id = Guid.NewGuid(),
            Title = newPublishingOfficeTitle,
            Location = newPublishingOfficeLocation,
            Contacts = newPublishingOfficeContacts
       }; 

       DbLibrary._publishingOfficesId.Add(newPublishingOffice.Id);

       Console.WriteLine("New Publishinf Office added!");
       Console.WriteLine("New Publishing Office Id: " + Create(newPublishingOffice.ToDbPublishingOffice()));
    }

    public bool AddBook(Guid publishingOfficeId, Guid bookId)
    {
        DbPublishingOffice? publishingOffice = Get(publishingOfficeId);

        if (publishingOffice == null)
            return false;

        publishingOffice._booksId.Add(bookId);
        
        return true;
        
    }
    public Guid Create(DbPublishingOffice publishingOffice)
    {
        LibraryData._publishingOfficesBase[publishingOffice.Id] = publishingOffice;
        return publishingOffice.Id;
    }

    public bool Delete(Guid id)
    {
        if (LibraryData._publishingOfficesBase.TryGetValue(id, out DbPublishingOffice? publishingOffice))
        {
            LibraryData._publishingOfficesBase.Remove(id);
            return true;
        }
        return false;
    }

    public bool Update(DbPublishingOffice newPublishingOffice)
    {
        if (LibraryData._publishingOfficesBase.TryGetValue(newPublishingOffice.Id, out DbPublishingOffice? publishingOffice))
        {
            LibraryData._publishingOfficesBase[newPublishingOffice.Id] = newPublishingOffice;
            return true;
        }
        return false;
    }

    public List<DbPublishingOffice> Get() => LibraryData._publishingOfficesBase.Values.ToList();

    public DbPublishingOffice? Get(Guid id)
    {
        if (LibraryData._publishingOfficesBase.TryGetValue(id, out DbPublishingOffice? publishingOffice))
        {
            return publishingOffice;
        }
        return null;
    }
}