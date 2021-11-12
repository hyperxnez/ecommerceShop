using System;
using System.Collections.Generic;

#nullable disable

namespace ASP_NETCore_Working_EF.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Bills = new HashSet<Bill>();
        }

        public int Cid { get; set; }
        public string Cname { get; set; }
        public string Cphone { get; set; }
        public string CAddress { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public bool? Status { get; set; }
        public bool? Role { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
