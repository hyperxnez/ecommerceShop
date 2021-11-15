using System;
using System.Collections.Generic;

#nullable disable

namespace ASP_NETCore_Working_EF.Models
{
    public partial class CheckoutInfo
    {
        public CheckoutInfo()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public int? CountryId { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Comment { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
