using System;
using System.Collections.Generic;

#nullable disable

namespace testAuth2.models
{
    public partial class LmcorderDetailsTable
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public string Notes { get; set; }

        public virtual Lmcorder Order { get; set; }
    }
}
