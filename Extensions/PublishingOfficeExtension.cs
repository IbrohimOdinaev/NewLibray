using DbObjects;
using ObjectsDto;

namespace Extensions;

public static class PublishingOfficeExtension
{
    public static DbPublishingOffice ToDbPublishingOffice(this PublishingOfficeDto publishingOffice)
        => new() 
    {
        Id = publishingOffice.Id,

        Title = publishingOffice.Title,
        Location = publishingOffice.Location!.ToDbLocation(),
        Contacts = publishingOffice.Contacts!.ToDbContacts(),
    };

    public static PublishingOfficeDto ToPublishingOfficeDto(this DbPublishingOffice publishingOffice)
        => new()
    {
        Id = publishingOffice.Id,

        Title = publishingOffice.Title,
        Location = publishingOffice.Location!.ToLocationDto(),
        Contacts = publishingOffice.Contacts!.ToContactsDto(),

        _booksId = publishingOffice._booksId
    };
}