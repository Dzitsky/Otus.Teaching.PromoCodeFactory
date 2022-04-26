using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement
{    public class Customer
           : BaseEntity
    {
        //[Required]
        //[MaxLength(100)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Email { get; set; }
        public virtual ICollection<CustomerPreference> Preferences { get; set; } = new List<CustomerPreference>();
        public virtual ICollection<PromoCode> PromoCodes { get; set; } = new List<PromoCode>();
    }
}
