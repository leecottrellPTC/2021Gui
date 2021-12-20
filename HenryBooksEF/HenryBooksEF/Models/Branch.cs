using System;
using System.Collections.Generic;

#nullable disable

namespace HenryBooksEF.Models
{
    public partial class Branch
    {
        public Branch()
        {
            Copies = new HashSet<Copy>();
        }

        public decimal BranchNum { get; set; }
        public string BranchName { get; set; }
        public string BranchLocation { get; set; }

        public virtual ICollection<Copy> Copies { get; set; }
    }
}
