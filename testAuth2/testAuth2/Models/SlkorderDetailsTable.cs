using System;
using System.Collections.Generic;

#nullable disable

namespace testAuth2.models
{
    public partial class SlkorderDetailsTable
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int PropId { get; set; }
        public int Quantity { get; set; }

        public virtual Slkorder Order { get; set; }
    }
}
