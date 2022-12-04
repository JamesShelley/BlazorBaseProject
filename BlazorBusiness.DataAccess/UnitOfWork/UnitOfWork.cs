using BlazorBusiness.DataAccess.Repositories;
using BlazorBusiness.Domain.Interfaces;

namespace BlazorBusiness.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IContactRepository Contacts { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Contacts = new ContactRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync(); 
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
