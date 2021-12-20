using System;
using System.Collections.Generic;

#nullable disable

namespace testAuth2.models
{
    public partial class Amrorder
    {
        public Amrorder()
        {
            AmrorderDetailsTables = new HashSet<AmrorderDetailsTable>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int EmpId { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual ICollection<AmrorderDetailsTable> AmrorderDetailsTables { get; set; }
    }
}
