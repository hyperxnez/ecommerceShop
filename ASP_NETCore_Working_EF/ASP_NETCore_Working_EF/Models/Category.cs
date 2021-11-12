using System;
using System.Collections.Generic;

#nullable disable

namespace ASP_NETCore_Working_EF.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CateId { get; set; }
        public string CateName { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
