﻿using System;
using System.Collections.Generic;

#nullable disable

namespace testAuth2.models
{
    public partial class LjgorderDetailsTable
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int PropId { get; set; }
        public int Quantity { get; set; }

        public virtual Ljgorder Order { get; set; }
    }
}
