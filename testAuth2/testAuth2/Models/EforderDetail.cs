using System;
using System.Collections.Generic;

#nullable disable

namespace testAuth2.models
{
    public partial class EforderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProdId { get; set; }
        public int Quantity { get; set; }

        public virtual Eforder Order { get; set; }
    }
}
