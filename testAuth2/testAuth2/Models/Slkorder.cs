using System;
using System.Collections.Generic;

#nullable disable

namespace testAuth2.models
{
    public partial class Slkorder
    {
        public Slkorder()
        {
            SlkorderDetailsTables = new HashSet<SlkorderDetailsTable>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int EmpId { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual ICollection<SlkorderDetailsTable> SlkorderDetailsTables { get; set; }
    }
}
