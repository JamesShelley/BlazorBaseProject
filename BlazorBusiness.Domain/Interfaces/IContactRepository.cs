using BlazorBusiness.Domain.Entities.CRM;

namespace BlazorBusiness.Domain.Interfaces
{
    public interface IContactRepository : IGenericRepository<Contact>
    {
        IEnumerable<Contact> GetImportantContacts(int rating);
    }
}
