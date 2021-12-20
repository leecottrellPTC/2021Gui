using System;
using System.Collections.Generic;

#nullable disable

namespace testAuth2.models
{
    public partial class Wrote
    {
        public string BookCode { get; set; }
        public decimal AuthorNum { get; set; }
        public decimal? Sequence { get; set; }

        public virtual Author AuthorNumNavigation { get; set; }
        public virtual Book BookCodeNavigation { get; set; }
    }
}
