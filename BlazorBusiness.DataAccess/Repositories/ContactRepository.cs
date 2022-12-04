using BlazorBusiness.Domain.Entities.CRM;
using BlazorBusiness.Domain.Interfaces;

namespace BlazorBusiness.DataAccess.Repositories
{
    public class ContactRepository : GenericRepository<Contact>, IContactRepository
    {
        public ContactRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<Contact> GetImportantContacts(int rating)
        {
            return _context.Contacts.Where(x => x.Rating > rating).ToList();
        }
    }
}
