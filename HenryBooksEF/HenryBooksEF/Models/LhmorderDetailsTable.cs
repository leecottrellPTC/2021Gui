using System;
using System.Collections.Generic;

#nullable disable

namespace HenryBooksEF.Models
{
    public partial class LhmorderDetailsTable
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int PropId { get; set; }
        public int Quantity { get; set; }

        public virtual Lhmorder Order { get; set; }
    }
}
