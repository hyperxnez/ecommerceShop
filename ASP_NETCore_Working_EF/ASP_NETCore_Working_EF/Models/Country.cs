using System;
using System.Collections.Generic;

#nullable disable

namespace ASP_NETCore_Working_EF.Models
{
    public partial class Country
    {
        public Country()
        {
            CheckoutInfos = new HashSet<CheckoutInfo>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CheckoutInfo> CheckoutInfos { get; set; }
    }
}
