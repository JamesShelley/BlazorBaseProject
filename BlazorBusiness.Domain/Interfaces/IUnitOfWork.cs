namespace BlazorBusiness.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IContactRepository Contacts { get; }
        int Complete();
        Task<int> CompleteAsync();

    }
}
