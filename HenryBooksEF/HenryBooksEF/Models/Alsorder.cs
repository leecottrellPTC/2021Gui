using System;
using System.Collections.Generic;

#nullable disable

namespace HenryBooksEF.Models
{
    public partial class Alsorder
    {
        public Alsorder()
        {
            AlsorderDetailsTables = new HashSet<AlsorderDetailsTable>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int EmpId { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual ICollection<AlsorderDetailsTable> AlsorderDetailsTables { get; set; }
    }
}
