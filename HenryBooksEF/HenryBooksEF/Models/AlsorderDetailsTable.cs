using System;
using System.Collections.Generic;

#nullable disable

namespace HenryBooksEF.Models
{
    public partial class AlsorderDetailsTable
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int PropId { get; set; }
        public int Quantity { get; set; }

        public virtual Alsorder Order { get; set; }
    }
}
