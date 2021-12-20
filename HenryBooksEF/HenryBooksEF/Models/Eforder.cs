using System;
using System.Collections.Generic;

#nullable disable

namespace HenryBooksEF.Models
{
    public partial class Eforder
    {
        public Eforder()
        {
            EforderDetails = new HashSet<EforderDetail>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int EmpId { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual ICollection<EforderDetail> EforderDetails { get; set; }
    }
}
