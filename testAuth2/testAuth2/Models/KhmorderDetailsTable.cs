using System;
using System.Collections.Generic;

#nullable disable

namespace testAuth2.models
{
    public partial class KhmorderDetailsTable
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int PropId { get; set; }
        public int Quantity { get; set; }

        public virtual Khmorder Order { get; set; }
    }
}
