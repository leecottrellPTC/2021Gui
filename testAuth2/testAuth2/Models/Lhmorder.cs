using System;
using System.Collections.Generic;

#nullable disable

namespace testAuth2.models
{
    public partial class Lhmorder
    {
        public Lhmorder()
        {
            LhmorderDetailsTables = new HashSet<LhmorderDetailsTable>();
        }

        public int OrderId { get; set; }
        public int CustId { get; set; }
        public int EmpId { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual ICollection<LhmorderDetailsTable> LhmorderDetailsTables { get; set; }
    }
}
