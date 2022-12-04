using AutoMapper;
using BlazorBusiness.Core.Models.CommonModels.CRM;
using BlazorBusiness.Domain.Entities.CRM;
using BlazorBusiness.Domain.Interfaces;

namespace BlazorBusiness.Core.Services
{
    public sealed class ContactService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ContactService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<ContactViewModel>> GetContactsAsync()
        {
            var crmContacts = await _unitOfWork.Contacts.GetAllAsync();
            return _mapper.Map<List<ContactViewModel>>(crmContacts);
        }

        public void CreateContactRecord(ContactFormSubmission contact)
        {
            var contactRecord = _mapper.Map<Contact>(contact);
            contactRecord.Created = DateTime.Now;
            contactRecord.LastModified = DateTime.Now;
             _unitOfWork.Contacts.Add(contactRecord);
            _unitOfWork.Complete();
        }

    }
}
