using System.ComponentModel.DataAnnotations;

namespace BlazorBusiness.Core.Models.CommonModels.CRM
{
    public class ContactFormSubmission
    {
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        [EmailAddress]
        public string? EmailAddress { get; set; }
    }
}
