using System;
using System.Collections.Generic;

#nullable disable

namespace ASP_NETCore_Working_EF.Models
{
    public partial class Product
    {
        public Product()
        {
            BillDetails = new HashSet<BillDetail>();
        }

        public string Pid { get; set; }
        public string Pname { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public bool? Status { get; set; }
        public int? CateId { get; set; }

        public virtual Category Cate { get; set; }
        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}
