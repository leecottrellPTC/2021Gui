using System;
using System.Collections.Generic;

#nullable disable

namespace testAuth2.models
{
    public partial class Copy
    {
        public string BookCode { get; set; }
        public decimal BranchNum { get; set; }
        public decimal CopyNum { get; set; }
        public string Quality { get; set; }
        public decimal? Price { get; set; }

        public virtual Book BookCodeNavigation { get; set; }
        public virtual Branch BranchNumNavigation { get; set; }
    }
}
