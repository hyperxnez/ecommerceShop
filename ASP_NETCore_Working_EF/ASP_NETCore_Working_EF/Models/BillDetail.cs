using System;
using System.Collections.Generic;

#nullable disable

namespace ASP_NETCore_Working_EF.Models
{
    public partial class BillDetail
    {
        public string Pid { get; set; }
        public string OId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? Total { get; set; }

        public virtual Bill OIdNavigation { get; set; }
        public virtual Product PidNavigation { get; set; }
    }
}
