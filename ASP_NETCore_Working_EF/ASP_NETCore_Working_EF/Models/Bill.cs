using System;
using System.Collections.Generic;

#nullable disable

namespace ASP_NETCore_Working_EF.Models
{
    public partial class Bill
    {
        public Bill()
        {
            BillDetails = new HashSet<BillDetail>();
        }

        public string OId { get; set; }
        public DateTime? DateCreate { get; set; }
        public string Cname { get; set; }
        public string Cphone { get; set; }
        public string CAddress { get; set; }
        public decimal? Total { get; set; }
        public int? Status { get; set; }
        public int? Cid { get; set; }

        public virtual Customer CidNavigation { get; set; }
        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}
